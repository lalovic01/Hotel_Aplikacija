using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatPrvi5220
{
    [Serializable]
    public class Korisnik
    {
        private static int id_global = 0;
        private int ID;
        private string ime;
        private string prezime;
        private string korisicko_ime;
        private string lozinka;
        private bool admin;
        public Korisnik(string ime, string prezime, string korisicko_ime, string lozinka, bool admin)
        {
            this.ID1 = id_global++;

            this.Ime = ime;
            this.Prezime = prezime;
            this.Korisicko_ime = korisicko_ime;
            this.Lozinka = lozinka;
            this.Admin = admin;
        }
        public Korisnik(int id, string ime, string prezime, string korisicko_ime, string lozinka, bool admin)
        {
            this.ID1 = ++id;
            id_global = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Korisicko_ime = korisicko_ime;
            this.Lozinka = lozinka;
            this.Admin = admin;
        }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Korisicko_ime { get => korisicko_ime; set => korisicko_ime = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public bool Admin { get => admin; set => admin = value; }
        public int ID1 { get => ID; set => ID = value; }
        public override string ToString()
        {
            return $"ID:{this.ID1}, Ime:{this.ime}, Prezime:{this.prezime}, Korisnicko ime:{this.korisicko_ime}, Lozinka:{this.lozinka}, Admin:{this.admin}";
        }
    }
}
