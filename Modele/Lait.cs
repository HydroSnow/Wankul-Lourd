using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    public class Lait
    {
        public int id { get; set; }
        public string nom { get; set; }


        public Lait(Dictionary<string, string> dictionary)
        {
            this.id = dictionary["id"] == "" ? int.MaxValue : int.Parse(dictionary["id"]);
            this.nom = dictionary["nom"];
        }

        public Lait() { }
    }

    public class ResponseLait
    {
        public bool valid { get; set; }
        public Lait[] result { get; set; }
        public string error { get; set; }
    }
}
