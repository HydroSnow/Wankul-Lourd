using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    public class Fromage
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string origine { get; set; }
        public int lait { get; set; }
        public int type { get; set; }
        public string img { get; set; }
        public double prix { get; set; }

        public Fromage(int id, string nom, string origine, int lait, int type, string img, double prix)
        {
            this.id = id;
            this.nom = nom;
            this.origine = origine;
            this.lait = lait;
            this.type = type;
            this.img = img;
            this.prix = prix;
        }

        public Fromage() { }
    }

    public class ResponseFromage
    {
        public bool valid { get; set; }
        public Fromage[] result { get; set; }
        public string error { get; set; }
    }
}
