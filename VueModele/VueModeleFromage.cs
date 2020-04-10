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

        public string Create(Fromage fromage)
        {
            ResponseFromage responseFromage = Post(fromage);
            if (!responseFromage.valid)
                return responseFromage.error;
            return null;
        }

        public ResponseFromage ReadAll() { return Get(); }
    }
}
