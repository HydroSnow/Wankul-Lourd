using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    class VueModeleFromage : AbstractVueModele<Fromage, ResponseFromage>
    {
        protected override string GetApiUrl()
        {
            return "fromage";
        }

        public ResponseFromage ReadAll() { return GET(); }

        public string Create(Fromage fromage)
        {
            ResponseFromage responseFromage = POST(fromage);
            if (!responseFromage.valid)
                return responseFromage.error;
            return null;
        }

        public string Update(Fromage fromage)
        {
            ResponseFromage responseFromage = PUT(fromage, fromage.id);
            if (!responseFromage.valid)
                return responseFromage.error;
            return null;
        }

        public bool Delete(Fromage fromage) { return DELETE(fromage.id).valid; }
    }
}
