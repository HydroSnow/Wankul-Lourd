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
        public double prix { get; set; }
        public int lait { get; set; }
        public int type { get; set; }
        public string img { get; set; }


        public Fromage(Dictionary<string, string> dictionary)
        {
            this.id = dictionary["id"] == "" ? int.MaxValue : int.Parse(dictionary["id"]);
            this.nom = dictionary["nom"];
            this.origine = dictionary["origine"];
            this.lait = int.Parse(dictionary["lait"]);
            this.type = int.Parse(dictionary["type"]);
            this.img = dictionary["img"];
            this.prix = double.Parse(dictionary["prix"].Replace('.', ','));
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
