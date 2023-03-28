using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatPrvi5220
{
    [Serializable]
    public class Soba
    {
        private static int id_global = 0;
        private int ID;
        private int broj_sobe;
        private int broj_kreveta;
        private bool lux_soba;
        private int cena;
        private int popust;
        private int min_broj_dana;
        public Soba(int broj_sobe, int broj_kreveta, bool lux_soba, int cena, int popust, int min_broj_dana)
        {
            this.ID1 = id_global++;
            this.Broj_sobe = broj_sobe;
            this.Broj_kreveta = broj_kreveta;
            this.Lux_soba = lux_soba;
            this.Cena = cena;
            this.Popust = popust;
            this.Min_broj_dana = min_broj_dana;
        }
        public Soba(int id, int broj_sobe, int broj_kreveta, bool lux_soba, int cena, int popust, int min_broj_dana)
        {
            this.ID1 = ++id;
            id_global = id;
            this.Broj_sobe = broj_sobe;
            this.Broj_kreveta = broj_kreveta;
            this.Lux_soba = lux_soba;
            this.Cena = cena;
            this.Popust = popust;
            this.Min_broj_dana = min_broj_dana;
        }
        public int ID1 { get => ID; set => ID = value; }
        public int Broj_sobe { get => broj_sobe; set => broj_sobe = value; }
        public int Broj_kreveta { get => broj_kreveta; set => broj_kreveta = value; }
        public bool Lux_soba { get => lux_soba; set => lux_soba = value; }
        public int Cena { get => cena; set => cena = value; }
        public int Popust { get => popust; set => popust = value; }
        public int Min_broj_dana { get => min_broj_dana; set => min_broj_dana = value; }
        public override string ToString()
        {
            return $"ID:{this.ID1}, Broj sobe:{this.broj_sobe}, Broj kreveta:{this.broj_kreveta}, Cena:{this.cena}, Popust:{this.popust}," +
                $" Minimalni broj dana:{this.min_broj_dana}, Lux soba:{this.lux_soba}";
        }
    }
    
}
