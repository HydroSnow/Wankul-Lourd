using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    class VueModeleUtilisateur : AbstractVueModele<Utilisateur, ResponseUtilisateur>
    {
        protected override string GetApiUrl()
        {
            return "utilisateur";
        }

        public ResponseUtilisateur ReadAll() { return GET(); }

        public string Create(Utilisateur utilisateur)
        {
            ResponseUtilisateur responseUtilisateur = POST(utilisateur);
            if (!responseUtilisateur.valid)
                return responseUtilisateur.error;
            return null;
        }

        public string Update(Utilisateur utilisateur)
        {
            ResponseUtilisateur responseUtilisateur = PUT(utilisateur, utilisateur.id);
            if (!responseUtilisateur.valid)
                return responseUtilisateur.error;
            return null;
        }

        public string Delete(int utilisateurId)
        {
            ResponseUtilisateur responseUtilisateur = DELETE(utilisateurId);
            if (!responseUtilisateur.valid)
                return responseUtilisateur.error;
            return null;
        }
    }
}
