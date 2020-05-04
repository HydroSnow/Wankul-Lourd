using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    class VueModeleLait : AbstractVueModele<Lait, ResponseLait>
    {
        protected override string GetApiUrl()
        {
            return "lait";
        }

        public ResponseLait ReadAll() { return GET(); }

        public string Create(Lait lait)
        {
            ResponseLait responseLait = POST(lait);
            if (!responseLait.valid)
                return responseLait.error;
            return null;
        }

        public string Update(Lait lait)
        {
            ResponseLait responseLait = PUT(lait, lait.id);
            if (!responseLait.valid)
                return responseLait.error;
            return null;
        }

        public string Delete(int laitId)
        {
            ResponseLait responseLait = DELETE(laitId);
            if (!responseLait.valid)
                return responseLait.error;
            return null;
        }
    }
}
