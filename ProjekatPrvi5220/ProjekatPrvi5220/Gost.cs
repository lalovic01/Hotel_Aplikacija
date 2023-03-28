using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatPrvi5220
{
    [Serializable]
    public class Gost
    {
        private static int id_global = 0;
        private int ID;
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private string telefon;

        public Gost(string ime, string prezime, DateTime datumRodjenja, string telefon)
        {
            this.ID1 = id_global++;
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.Telefon = telefon;
        }

        public Gost(int id, string ime, string prezime, DateTime datumRodjenja, string telefon)
        {
            this.ID1 = ++id;
            id_global = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.Telefon = telefon;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return $"ID:{this.ID1}, Ime:{this.ime}, Prezime: {this.prezime}, Datum Rodjenja:{this.datumRodjenja.Date.ToString("d")}, Telefon:{this.telefon}";
        }
    }
}
