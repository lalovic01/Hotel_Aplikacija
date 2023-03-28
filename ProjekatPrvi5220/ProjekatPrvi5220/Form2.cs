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
    public partial class Form2 : Form
    {
        string korisnici_datoteka;
        List<Korisnik> korisnici;
        int id;

        string gosti_datoteka;
        List<Gost> gosti;
        int id_gost;

        string sobe_datoteka;
        List<Soba> sobe;
        int id_soba;

        string rezervacije_datoteka;
        List<Rezervacija> rezervacije;
        public Form2()
        {
            InitializeComponent();
            korisnici_datoteka = Form1.korisnici_datoteka;
            korisnici = new List<Korisnik>();

            gosti_datoteka = Form1.gosti_datoteka;
            gosti = new List<Gost>();
            datumGDg.MaxDate = DateTime.Now;

            sobe_datoteka = Form1.sobe_datoteka;
            sobe = new List<Soba>();

            rezervacije_datoteka = Form1.rezervacije_datoteka;
            rezervacije = new List<Rezervacija>();
        }

        private void sacuvajBtn_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Open(korisnici_datoteka, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, korisnici);

            foreach (Korisnik k in korisnici)
            {
                streamWriter.WriteLine(k.ToString());
            }

            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();
            
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

            FileStream fsSoba = File.Open(sobe_datoteka, FileMode.Create);  
            StreamWriter streamWriterSoba = new StreamWriter(fsSoba);
            BinaryFormatter bfSoba = new BinaryFormatter();
            bfSoba.Serialize(fsSoba, sobe);

            foreach (Soba s in sobe)
            {
                streamWriterSoba.WriteLine(s.ToString());
            }

            streamWriterSoba.Flush();
            streamWriterSoba.Close();
            fsSoba.Close();

            FileStream fsRez = File.Open(rezervacije_datoteka, FileMode.Create);  //kod za cuvanje u datoteku pri odjavi
            StreamWriter streamWriterRez = new StreamWriter(fsRez);
            BinaryFormatter bfRez = new BinaryFormatter();
            bfRez.Serialize(fsRez, rezervacije);

            foreach (Rezervacija r in rezervacije)
            {
                streamWriterRez.WriteLine(r.ToString());
            }

            streamWriterRez.Flush();
            streamWriterRez.Close();
            fsRez.Close();
            MessageBox.Show("Uspešno ste sačuvali podatke!");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists(korisnici_datoteka))
            {
                FileStream fs = File.OpenRead(korisnici_datoteka);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                korisnici = bf.Deserialize(fs) as List<Korisnik>;

                korisniciLb.DataSource = korisnici;

                streamReader.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Greska! Datoteka nije pronadjena!");
            }

            if (File.Exists(gosti_datoteka))
            {
                FileStream fs = File.OpenRead(gosti_datoteka);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                gosti = bf.Deserialize(fs) as List<Gost>;

                gostiLb.DataSource = gosti;

                streamReader.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Greska! Datoteka nije pronadjena!");
            }

            if (File.Exists(sobe_datoteka))
            {
                FileStream fs = File.OpenRead(sobe_datoteka);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                sobe = bf.Deserialize(fs) as List<Soba>;

                sobeLb.DataSource = sobe;

                streamReader.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Greska! Datoteka nije pronadjena!");
            }

            if (File.Exists(rezervacije_datoteka))
            {
                FileStream fs = File.OpenRead(rezervacije_datoteka);
                StreamReader streamReader = new StreamReader(fs);

                BinaryFormatter bf = new BinaryFormatter();
                rezervacije = bf.Deserialize(fs) as List<Rezervacija>;

                rezervacijaLb.DataSource = rezervacije;

                streamReader.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Greska! Datoteka nije pronadjena!");
            }
        }

        private void azurirajKBtn_Click(object sender, EventArgs e)
        {
            id = korisnici[korisnici.Count - 1].ID1; //Dobijanje poslednjeg id-a
            if (idKTxb.Text == "")
            {
                bool admin = false;
                if (adminKCb.Checked)
                {
                    admin = true;
                }
                if (imeKTxb.Text == "" || prezimeKTxb.Text == "" || lozinkaKTxb.Text == "" || korisnikKTxb.Text == "")
                {
                    MessageBox.Show("Niste uneli sve informacije!");
                }
                else
                {
                    Korisnik kor = new Korisnik(id, imeKTxb.Text, prezimeKTxb.Text, korisnikKTxb.Text, lozinkaKTxb.Text, admin);
                    korisnici.Add(kor);

                    korisniciLb.DataSource = null;
                    korisniciLb.Items.Clear();
                    korisniciLb.DataSource = korisnici;

                    idKTxb.Clear();
                    imeKTxb.Clear();
                    prezimeKTxb.Clear();
                    korisnikKTxb.Clear();
                    lozinkaKTxb.Clear();

                    MessageBox.Show("Uspesno ste dodali Korisnika!");
                }
                   
            }
            else
            {
                if (int.TryParse(idKTxb.Text, out int idPom))
                {
                    bool izmena = false;
                    foreach (Korisnik k in korisnici)
                    {

                        if (int.Parse(idKTxb.Text) == k.ID1)
                        {
                            izmena = true;
                            if (!(imeKTxb.Text == ""))
                            {
                                k.Ime = imeKTxb.Text;
                            }
                            if (!(prezimeKTxb.Text == ""))
                            {
                                k.Prezime = prezimeKTxb.Text;
                            }
                            if (!(korisnikKTxb.Text == ""))
                            {
                                k.Korisicko_ime = korisnikKTxb.Text;
                            }
                            if (!(lozinkaKTxb.Text == ""))
                            {
                                k.Lozinka = lozinkaKTxb.Text;
                            }
                            if (adminKCb.Checked)
                            {
                                k.Admin = true;
                            }
                            else
                            {
                                k.Admin = false;
                            }
                            korisniciLb.DataSource = null;
                            korisniciLb.Items.Clear();
                            korisniciLb.DataSource = korisnici;

                            MessageBox.Show("Uspesno ste azurirali Korisnika!");
                        }
                    }
                    if (izmena == false)
                    {
                        MessageBox.Show("Korisnik sa tim Id-om ne postoji!");
                    }
                }
                else
                {
                    MessageBox.Show("ID mora da bude broj!");
                }
            }
        }

        private void ukloniBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idKTxb.Text, out int idPom))
            {
                bool obrisano = false;
                if (!(idKTxb.Text == ""))
                {
                    for (int i = 0; i < korisnici.Count; i++)
                    {
                        if (korisnici[i].ID1 == int.Parse(idKTxb.Text))
                        {
                            korisnici.RemoveAt(i);
                            korisniciLb.DataSource = null;
                            korisniciLb.Items.Clear();
                            korisniciLb.DataSource = korisnici;
                            obrisano = true;
                            MessageBox.Show("Korisnik uspesno obrisan!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unesite id!");
                }
                    

                if (obrisano == false && !(idKTxb.Text == ""))
                {
                    MessageBox.Show("Ne postoji korisnik sa tim id-om");
                }
            }
            else
            {
                MessageBox.Show("ID mora da bude broj!");
            }
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void azurirajGBtn_Click(object sender, EventArgs e)
        {
            id_gost = gosti[gosti.Count - 1].ID1;

            if (idGTb.Text == "")
            {
                if (imeGTb.Text == "" || prezimeGTb.Text == "" || !int.TryParse(telefonGTb.Text, out int telPom) || telefonGTb.Text == "" || datumGDg.Value.ToString() == "")
                {
                    MessageBox.Show("Niste uneli sve podatke pravilno!");
                }
                else
                {
                    var datumGostaRodjenje = Convert.ToDateTime(datumGDg.Text);
                    var ts = DateTime.Today - datumGostaRodjenje;
                    var godina = DateTime.MinValue.Add(ts).Year - 1;
                    if (godina >= 18)
                    {
                        Gost gost = new Gost(id_gost, imeGTb.Text, prezimeGTb.Text, datumGDg.Value, telefonGTb.Text);

                        gosti.Add(gost);

                        gostiLb.DataSource = null;
                        gostiLb.Items.Clear();
                        gostiLb.DataSource = gosti;

                        idGTb.Clear();
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
            else
            {
                if (int.TryParse(idGTb.Text, out int idPom))
                {
                    bool izmena = false;
                    foreach (Gost g in gosti)
                    {

                        if (int.Parse(idGTb.Text) == g.ID1)
                        {
                            izmena = true;
                            if (!(imeGTb.Text == ""))
                            {
                                g.Ime = imeGTb.Text;
                            }
                            if (!(prezimeGTb.Text == ""))
                            {
                                g.Prezime = prezimeGTb.Text;
                            }
                            if (!(telefonGTb.Text == ""))
                            {
                                if (int.TryParse(telefonGTb.Text, out int TelPom))
                                {
                                    g.Telefon = telefonGTb.Text;
                                }
                                else
                                    MessageBox.Show("Telefon mora da bude broj!");
                            }
                            if (!(datumGDg.Value.ToString() == ""))
                            {
                                g.DatumRodjenja = datumGDg.Value;
                            }

                            gostiLb.DataSource = null;
                            gostiLb.Items.Clear();
                            gostiLb.DataSource = gosti;

                            MessageBox.Show("Uspesno ste azurirali Gosta!");
                        }
                    }
                    if (izmena == false)
                    {
                        MessageBox.Show("Gost sa tim Id-om ne postoji!");
                    }
                }
                else
                {
                    MessageBox.Show("Id mora da bude broj!");
                }
            }
        }

        private void ukloniGBtn_Click(object sender, EventArgs e)
        {
            bool obrisano = false;
            if (int.TryParse(idGTb.Text, out int idPom))
            {
                if (!(idGTb.Text == ""))
                {
                    for (int i = 0; i < gosti.Count; i++)
                    {
                        if (gosti[i].ID1 == int.Parse(idGTb.Text))
                        {
                            gosti.RemoveAt(i);
                            gostiLb.DataSource = null;
                            gostiLb.Items.Clear();
                            gostiLb.DataSource = gosti;
                            obrisano = true;
                            idGTb.Clear();


                            MessageBox.Show("Uspesno ste uklonili gosta!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unesite id!");
                }
                if (obrisano == false && !(idGTb.Text == ""))
                {
                    MessageBox.Show("Ne postoji gost sa tim id-om");
                }
            }
            else
            {
                MessageBox.Show("Id mora da bude broj!");
            }
        }

        private void azurirajSBtn_Click(object sender, EventArgs e)
        {
            id_soba = sobe[sobe.Count - 1].ID1;

            if (idSTxb.Text == "")
            {
                bool lux = false;
                if (luxCb.Checked)
                {
                    lux = true;
                }
                if (brSTxb.Text == "" || bkSTxb.Text == "" || minSTxb.Text == "" || popustSTxb.Text == "" || !int.TryParse(brSTxb.Text, out int brPom) || !int.TryParse(bkSTxb.Text, out int brkrePom) || !int.TryParse(minSTxb.Text, out int minPom) || !int.TryParse(cenaSTxb.Text, out int cenaPom) || !int.TryParse(popustSTxb.Text, out int popustPom))
                {
                    MessageBox.Show("Niste uneli sve podatke pravilno!");
                }
                else
                {
                    bool postoji = false;
                    foreach (Soba s1 in sobe)
                    {
                        if (s1.Broj_sobe == int.Parse(brSTxb.Text))
                        {
                            postoji = true;
                        }
                    }
                    if (postoji == true)
                    {
                        MessageBox.Show("Vec postoji soba sa tim brojem!");
                    }
                    else
                    {
                        Soba soba = new Soba(id_soba, int.Parse(brSTxb.Text), int.Parse(bkSTxb.Text), lux, int.Parse(cenaSTxb.Text), int.Parse(popustSTxb.Text), int.Parse(minSTxb.Text));
                        sobe.Add(soba);


                        sobeLb.DataSource = null;
                        sobeLb.Items.Clear();
                        sobeLb.DataSource = sobe;

                        idSTxb.Clear();
                        brSTxb.Clear();
                        cenaSTxb.Clear();
                        bkSTxb.Clear();
                        minSTxb.Clear();
                        popustSTxb.Clear();

                        MessageBox.Show("Uspesno ste dodali Sobu!");
                    }
                }
            }
            else
            {
                if (int.TryParse(idSTxb.Text, out int idPom))
                {
                    bool izmena = false;    
                    bool greska = false;    
                    foreach (Soba s in sobe)
                    {

                        if (int.Parse(idSTxb.Text) == s.ID1)
                        {
                            izmena = true;
                            if (!(brSTxb.Text == ""))
                            {
                                bool postoji = false;
                                if (int.TryParse(brSTxb.Text, out int brsobe))
                                {
                                    foreach (Soba s1 in sobe)
                                    {
                                        if (brsobe == s1.Broj_sobe)
                                        {
                                            postoji = true;
                                        }
                                    }
                                    if (postoji == true)
                                    {
                                        MessageBox.Show("Soba sa tim brojem vec postoji!");
                                    }
                                    else
                                    {
                                        s.Broj_sobe = brsobe;
                                    }
                                }
                                else
                                    greska = true;
                            }
                            if (!(bkSTxb.Text == ""))
                            {
                                if (int.TryParse(bkSTxb.Text, out int krePom))
                                {
                                    s.Broj_kreveta = krePom;
                                }
                                else
                                    greska = true;
                            }
                            if (!(cenaSTxb.Text == ""))
                            {
                                if (int.TryParse(cenaSTxb.Text, out int cenaPom))
                                {
                                    s.Cena = cenaPom;
                                }
                                else
                                    greska = true;
                            }
                            if (!(popustSTxb.Text == ""))
                            {
                                if (int.TryParse(popustSTxb.Text, out int popustPom))
                                {
                                    s.Popust = popustPom;
                                }
                                else
                                    greska = true;
                            }
                            if (!(minSTxb.Text == ""))
                            {
                                if (int.TryParse(minSTxb.Text, out int minPom))
                                {
                                    s.Min_broj_dana = minPom;
                                }
                                else
                                    greska = true;
                            }
                            if (luxCb.Checked)
                            {
                                s.Lux_soba = true;
                            }
                            else
                            {
                                s.Lux_soba = false;
                            }

                            if (greska == false)
                            {
                                sobeLb.DataSource = null;
                                sobeLb.Items.Clear();
                                sobeLb.DataSource = sobe;
                            }
                            else
                            {
                                MessageBox.Show("Nisu svi podaci uneti pravilno!");
                            }
                            MessageBox.Show("Uspesno ste azurirali Sobu!");
                        }
                    }
                    if (izmena == false)
                    {
                        MessageBox.Show("Soba sa tim Id-om ne postoji!");
                    }
                }
                else
                    MessageBox.Show("Id mora da bude broj!");
            }
        }

        private void ukloniSBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idSTxb.Text, out int idPom))
            {
                bool obrisano = false;
                if (!(idSTxb.Text == ""))
                {
                    for (int i = 0; i < sobe.Count; i++)
                    {
                        if (sobe[i].ID1 == int.Parse(idSTxb.Text))
                        {
                            sobe.RemoveAt(i);
                            sobeLb.DataSource = null;
                            sobeLb.Items.Clear();
                            sobeLb.DataSource = sobe;
                            obrisano = true;

                            MessageBox.Show("Uspesno ste uklonili sobu!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Unesite id!");
                }
                if (obrisano == false && !(brSTxb.Text == ""))
                {
                    MessageBox.Show("Ne postoji soba sa tim id-om");
                }
            }
            else
            {
                MessageBox.Show("Id mora da bude broj!");
            }
        }

        private void azurirajRBtn_Click(object sender, EventArgs e)
        {
            bool promena = false;
            if (int.TryParse(idRTxb.Text, out int rezId) && idRTxb.Text != null)
            {
                foreach (Rezervacija r in rezervacije)
                {
                    if (r.ID1 == rezId)
                    {
                        if (int.TryParse(cenaRtxb.Text, out int rezCena) && cenaRtxb.Text != null)
                        {
                            r.Ukupna_cena = rezCena;
                            promena = true;

                            MessageBox.Show("Uspesno ste azurirali Rezervaciju!");
                        }
                        else
                        {
                            MessageBox.Show("Unesite pravilno cenu!");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Unesite pravilno ID!");

            if (promena != true && idRTxb.Text != "")
            {
                MessageBox.Show("Ne postoji soba sa tim ID-om!");
            }

            rezervacijaLb.DataSource = null;
            rezervacijaLb.Items.Clear();
            rezervacijaLb.DataSource = rezervacije;

            idRTxb.Clear();
            cenaRtxb.Clear();
        }

        private void ukloniRBtn_Click(object sender, EventArgs e)
        {
            bool promena = false;
            if (int.TryParse(idRTxb.Text, out int rezId) && idRTxb.Text != null)
            {
                for (int i = 0; i < rezervacije.Count; i++)
                {
                    if (rezervacije[i].ID1 == rezId)
                    {
                        rezervacije.RemoveAt(i--);
                        promena = true;

                        MessageBox.Show("Uspesno ste uklonili Rezervaciju!");
                    }
                }
            }
            else
                MessageBox.Show("Unesite pravilno ID!");

            if (promena != true && idRTxb.Text != "")
            {
                MessageBox.Show("Ne postoji soba sa tim ID-om!");
            }

            rezervacijaLb.DataSource = null;
            rezervacijaLb.Items.Clear();
            rezervacijaLb.DataSource = rezervacije;
        }

        private void refresujBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
        }

        private void odjavaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
