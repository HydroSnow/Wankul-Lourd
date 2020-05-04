using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    public class Type
    {
        public int id { get; set; }
        public string nom { get; set; }


        public Type(Dictionary<string, string> dictionary)
        {
            this.id = dictionary["id"] == "" ? int.MaxValue : int.Parse(dictionary["id"]);
            this.nom = dictionary["nom"];
        }

        public Type() { }
    }

    public class ResponseType
    {
        public bool valid { get; set; }
        public Type[] result { get; set; }
        public string error { get; set; }
    }
}
