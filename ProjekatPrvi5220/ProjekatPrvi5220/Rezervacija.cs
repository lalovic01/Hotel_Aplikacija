using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatPrvi5220
{
    [Serializable]
    public class Rezervacija
    {
        private static int id_global = 0;
        private int ID;
        private int ID_soba;
        private int ID_gosta;
        private DateTime datum_prijave;
        private DateTime datum_odjave;
        private float ukupna_cena;
        private string tip_rezervacije;
        public Rezervacija(int iD_soba, int iD_gosta, DateTime datum_prijave, DateTime datum_odjave, float ukupna_cena, string tip_rezervacije)
        {
            this.ID1 = id_global++;
            this.ID_soba1 = iD_soba;
            this.ID_gosta1 = iD_gosta;
            this.Datum_prijave = datum_prijave;
            this.Datum_odjave = datum_odjave;
            this.Ukupna_cena = ukupna_cena;
            this.Tip_rezervacije = tip_rezervacije;
        }
        public Rezervacija(int id, int iD_soba, int iD_gosta, DateTime datum_prijave, DateTime datum_odjave, float ukupna_cena, string tip_rezervacije)
        {
            this.ID1 = ++id;
            id_global = id;
            this.ID_soba1 = iD_soba;
            this.ID_gosta1 = iD_gosta;
            this.Datum_prijave = datum_prijave;
            this.Datum_odjave = datum_odjave;
            this.Ukupna_cena = ukupna_cena;
            this.Tip_rezervacije = tip_rezervacije;
        }
        public int ID1 { get => ID; set => ID = value; }
        public int ID_soba1 { get => ID_soba; set => ID_soba = value; }
        public int ID_gosta1 { get => ID_gosta; set => ID_gosta = value; }
        public DateTime Datum_prijave { get => datum_prijave; set => datum_prijave = value; }
        public DateTime Datum_odjave { get => datum_odjave; set => datum_odjave = value; }
        public float Ukupna_cena { get => ukupna_cena; set => ukupna_cena = value; }
        public string Tip_rezervacije { get => tip_rezervacije; set => tip_rezervacije = value; }
        public override string ToString()
        {
            return $"ID:{this.ID1}, ID Sobe:{this.ID_soba1}, ID Gosta:{this.ID_gosta1}, Datum prijave:{this.Datum_prijave.ToString("d")}, Datum odjave:{this.Datum_odjave.ToString("d")}" +
                $",Tip rezervacije:{this.Tip_rezervacije}, Cena:{this.Ukupna_cena}";
        }
    }
}
