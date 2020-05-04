using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    public class Token
    {
        public string id { get; set; }

        public Token() { }
    }

    public class ResponseToken
    {
        public bool valid { get; set; }
        public Token result { get; set; }
        public string error { get; set; }
    }
}
