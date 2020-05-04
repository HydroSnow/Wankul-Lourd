using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    public class Utilisateur
    {
        public int id { get; set; }
        public string nom { get; set; }
        public int role { get; set; }
        public string mdp { get; set; }


        public Utilisateur(Dictionary<string, string> dictionary)
        {
            this.id = dictionary["id"] == "" ? int.MaxValue : int.Parse(dictionary["id"]);
            this.nom = dictionary["nom"];
            this.role = int.Parse(dictionary["role"]);
            this.mdp = dictionary["mdp"];
        }

        public Utilisateur() { }
    }

    public class ResponseUtilisateur
    {
        public bool valid { get; set; }
        public Utilisateur[] result { get; set; }
        public string error { get; set; }
    }
}
