using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatPrvi5220
{
    public partial class Form3 : Form
    {
        string korisnici_datoteka;
        List<Korisnik> korisnici;

        string gosti_datoteka;
        List<Gost> gosti;
        int id_gost;

        string sobe_datoteka;
        List<Soba> sobe;
        List<Soba> sobePom = new List<Soba>();              //Pravljenje liste slobodnih soba

        string rezervacije_datoteka;
        List<Rezervacija> rezervacije;
        int id_rezervacije;

        DateTime datum_prijave;
        DateTime datum_odjave;
        DateTime tekuce_rezervacije;
        public Form3()
        {
            InitializeComponent();
            korisnici_datoteka = Form1.korisnici_datoteka;
            korisnici = new List<Korisnik>();

            gosti_datoteka = Form1.gosti_datoteka;
            gosti = new List<Gost>();

            sobe_datoteka = Form1.sobe_datoteka;
            sobe = new List<Soba>();

            rezervacije_datoteka = Form1.rezervacije_datoteka;
            rezervacije = new List<Rezervacija>();
        }

        private void refresujBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3();
            f3.ShowDialog();
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            FileStream fsGost = File.Open(gosti_datoteka, FileMode.Create);
            StreamWriter streamWriterGost = new StreamWriter(fsGost);
            BinaryFormatter bfGost = new BinaryFormatter();
            bfGost.Serialize(fsGost, gosti);

            foreach (Gost g in gosti)
            {
                streamWriterGost.WriteLine(g.ToString());
            }

            streamWriterGost.Flush();
            streamWriterGost.Close();
            fsGost.Close();


            FileStream fs = File.Open(rezervacije_datoteka, FileMode.Create);
            StreamWriter streamWriterSoba = new StreamWriter(fs);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, rezervacije);

            foreach (Rezervacija r in rezervacije)
            {
                streamWriterSoba.WriteLine(r.ToString());
            }

            streamWriterSoba.Flush();
            streamWriterSoba.Close();
            fs.Close();

            MessageBox.Show("Uspesno ste sacuvali rezervaciju!");
        }

        private void odjavaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (File.Exists(gosti_datoteka))
            {
                FileStream fs = File.OpenRead(gosti_datoteka);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                gosti = bf.Deserialize(fs) as List<Gost>;

                gostCb.DataSource = gosti;

                streamReader.Close();
                fs.Close();
            }

            if (File.Exists(sobe_datoteka))
            {
                FileStream fs = File.OpenRead(sobe_datoteka);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                sobe = bf.Deserialize(fs) as List<Soba>;

                sobaCb.DataSource = sobe;

                streamReader.Close();
                fs.Close();
            }
            //rezervacije
            if (File.Exists(rezervacije_datoteka))
            {
                FileStream fs = File.OpenRead(rezervacije_datoteka);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                rezervacije = bf.Deserialize(fs) as List<Rezervacija>;

                rezervacijeLb.DataSource = rezervacije;

                streamReader.Close();
                fs.Close();
            }

            datumGost.MaxDate = DateTime.Now;
            datumPrijava.MinDate = DateTime.Now;

            int minSobe = 0;
            int maxSobe = 0;
            int minCena = 0;
            int maxCena = 0;
            foreach (Soba s in sobe)
            {
                if (s.Min_broj_dana < minSobe)
                    minSobe = s.Min_broj_dana;
                if (s.Min_broj_dana > maxSobe)
                    maxSobe = s.Min_broj_dana;
                if (s.Cena < minCena)
                    minCena = s.Cena;
                if (s.Cena > maxCena)
                    maxCena = s.Cena;
            }
            krevetiTrb.Minimum = minSobe;
            krevetiTrb.Maximum = maxSobe;
            krevetiTrb.Value = maxSobe;
            cenaTrb.Minimum = minCena;
            cenaTrb.Maximum = maxCena;
            cenaTrb.Value = maxCena;

            foreach (Soba s in sobe)
            {
                sobePom.Add(s);
            }
            sobaCb.DataSource = null;
            sobaCb.Items.Clear();
            sobaCb.DataSource = sobePom;

            proveraDatume();
        }

        private void dodajBtn_Click(object sender, EventArgs e)
        {
            id_gost = gosti[gosti.Count - 1].ID1;               //Dodavanje novog gosta preko forme za rezervaciju


            if (imeGTb.Text == "" || prezimeGTb.Text == "" || !int.TryParse(telefonGTb.Text, out int telPom) || telefonGTb.Text == "" || datumGost.Value.ToString() == "")
            {
                MessageBox.Show("Niste uneli sve podatke pravilno!");
            }
            else
            {
                var datumGostaRodjenje = Convert.ToDateTime(datumGost.Text);
                var ts = DateTime.Today - datumGostaRodjenje;
                var godina = DateTime.MinValue.Add(ts).Year - 1;
                if (godina >= 18)
                {
                    Gost gost = new Gost(id_gost, imeGTb.Text, prezimeGTb.Text, datumGost.Value, telefonGTb.Text);

                    gosti.Add(gost);

                    gostCb.DataSource = null;
                    gostCb.Items.Clear();
                    gostCb.DataSource = gosti;

                    imeGTb.Clear();
                    prezimeGTb.Clear();
                    telefonGTb.Clear();

                    MessageBox.Show("Uspesno ste dodali Gosta!");
                }
                else
                {
                    MessageBox.Show("Korisnik je maloletan, nije moguće dodavanje!", "Pažnja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        int reset = 0;
        private void datumPrijava_ValueChanged(object sender, EventArgs e)
        {
            datum_prijave = datumPrijava.Value;
            datumOdjave.MinDate = datumPrijava.Value.AddDays(1);


            if (reset > 2)
            {
                resetujDatume();
                proveraDatume();
            }
            reset++;
        }

        private void datumOdjave_ValueChanged(object sender, EventArgs e)
        {
            datum_odjave = datumOdjave.Value.Date;

            if (reset > 2)
            {
                resetujDatume();
                proveraDatume();
            }
            reset++;
        }
        private void proveraDatume()
        {
            bool promena = false;
            foreach (Rezervacija r in rezervacije)
            {
                if (((r.Datum_prijave <= datum_prijave && r.Datum_odjave >= datum_prijave) || (r.Datum_prijave <= datum_odjave && r.Datum_odjave >= datum_odjave)) || (datum_prijave < r.Datum_prijave && datum_odjave > r.Datum_odjave))
                {
                    int idZauzeteSobe = r.ID_soba1;

                    for (int i = 0; i < sobePom.Count(); i++)
                    {
                        if (sobePom[i].ID1 == idZauzeteSobe)
                        {
                            sobePom.RemoveAt(i--);
                            promena = true;
                        }
                    }
                }
            }
            if (luxCb.Checked)
            {
                for (int i = 0; i < sobePom.Count; i++)
                {
                    if (sobePom[i].Lux_soba != true)
                    {
                        sobePom.RemoveAt(i--);
                        promena = true;
                    }
                }
            }
            for (int i = 0; i < sobePom.Count; i++)
            {
                if (!(sobePom[i].Broj_kreveta <= krevetiTrb.Value))
                {
                    sobePom.RemoveAt(i--);
                    promena = true;
                }
            }
            for (int i = 0; i < sobePom.Count; i++)
            {
                if (!(sobePom[i].Cena <= cenaTrb.Value))
                {
                    sobePom.RemoveAt(i--);
                    promena = true;
                }
            }
            if (promena)
            {
                azurirajDatume();
            }
        }
        private void resetujDatume()
        {
            sobePom = new List<Soba>(sobe);

            sobaCb.DataSource = null;
            sobaCb.Items.Clear();
            sobaCb.DataSource = sobePom;
        }
        private void azurirajDatume()
        {
            //Azuriranje soba u combo boxu
            sobaCb.DataSource = null;
            sobaCb.Items.Clear();
            sobaCb.DataSource = sobePom;
        }

        private void datumPr_ValueChanged(object sender, EventArgs e)
        {
            tekuce_rezervacije = datumPr.Value.Date;
            rezervacijeLb.DataSource = null;
            rezervacijeLb.Items.Clear();

            foreach (Rezervacija r in rezervacije)
            {
                if (tekuce_rezervacije >= r.Datum_prijave && tekuce_rezervacije < r.Datum_odjave)
                {
                    rezervacijeLb.Items.Add(r.ToString());
                }
            }
        }

        private void resetujGBtn_Click(object sender, EventArgs e)
        {
            rezervacijeLb.DataSource = null;
            rezervacijeLb.Items.Clear();
            rezervacijeLb.DataSource = rezervacije;

            proveraDatume();
        }

        private void cenaBtn_Click(object sender, EventArgs e)
        {
            bool greska = false;
            if (sobaCb.SelectedIndex <= -1)
            {
                greska = true;
                MessageBox.Show("Nije izabrana soba!");
                return;
            }


            double tipRezervacije = 0;
            switch (tipCb.Text)
            {
                case "Pun pansion":
                    tipRezervacije = 1;
                    break;
                case "Polu pansion":
                    tipRezervacije = 0.7;
                    break;
                case "Samo dorucak":
                    tipRezervacije = 0.5;
                    break;
                default:
                    MessageBox.Show("Unesite pravilno tip rezervacije!");
                    greska = true;
                    break;
            }


            List<Gost> gostiPom = new List<Gost>();
            foreach (Gost g in gostCb.Items)
            {
                gostiPom.Add(g);
            }


            double trajanjeRezervacije = (datum_odjave.Date - datum_prijave.Date).TotalDays;
            double ukupna_Cena;

            if (trajanjeRezervacije < sobePom[sobaCb.SelectedIndex].Min_broj_dana || trajanjeRezervacije < 0)
            {
                MessageBox.Show("Duzina rezervacije je kraća od minimalnog broja dana za tu sobu!");
                greska = true;
            }



            if (greska == false)                  //proveravanje da li je doslo do greske pri upisu podataka pred rezervisanje
            {
                ukupna_Cena = (trajanjeRezervacije) * (sobePom[sobaCb.SelectedIndex].Cena - sobePom[sobaCb.SelectedIndex].Popust) * tipRezervacije;   //racunanje ukupne cene rezervacije

                id_rezervacije = rezervacije[rezervacije.Count - 1].ID1;

                Rezervacija rez = new Rezervacija(id_rezervacije, sobePom[sobaCb.SelectedIndex].ID1, gostiPom[gostCb.SelectedIndex].ID1, datum_prijave.Date, datum_odjave.Date, (float)ukupna_Cena, tipCb.Text);
                rezervacije.Add(rez);

                rezervacijeLb.DataSource = null;
                rezervacijeLb.Items.Clear();
                rezervacijeLb.DataSource = rezervacije;

                cenaTxb.Text = ukupna_Cena.ToString();


                sobaCb.DataSource = null;
                sobaCb.Items.Clear();
                sobaCb.DataSource = sobePom;

                proveraDatume();

                MessageBox.Show("Uspesno dodato u listu Rezervacija");
            }
        }

        private void luxCb_CheckedChanged(object sender, EventArgs e)
        {
            resetujDatume();
            proveraDatume();
        }

        private void krevetiTrb_Scroll(object sender, EventArgs e)
        {
            resetujDatume();
            proveraDatume();
            lbBrKreveta.Text = krevetiTrb.Value.ToString();
        }

        private void cenaTrb_Scroll(object sender, EventArgs e)
        {
            resetujDatume();
            proveraDatume();
            lbCena.Text = cenaTrb.Value.ToString();
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
