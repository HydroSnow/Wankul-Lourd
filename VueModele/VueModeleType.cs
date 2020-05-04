using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    class VueModeleType : AbstractVueModele<Type, ResponseType>
    {
        protected override string GetApiUrl()
        {
            return "type";
        }

        public ResponseType ReadAll() { return GET(); }

        public string Create(Type type)
        {
            ResponseType responseType = POST(type);
            if (!responseType.valid)
                return responseType.error;
            return null;
        }

        public string Update(Type type)
        {
            ResponseType responseType = PUT(type, type.id);
            if (!responseType.valid)
                return responseType.error;
            return null;
        }

        public string Delete(int typeId)
        {
            ResponseType responseType = DELETE(typeId);
            if (!responseType.valid)
                return responseType.error;
            return null;
        }
    }
}
