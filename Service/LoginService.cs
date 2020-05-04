using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wankul
{
    sealed class LoginService
    {
        private static readonly Lazy<LoginService> singleInstance = new Lazy<LoginService>(() => new LoginService());

        private LoginService()
        {
        }

        public static LoginService SingleInstance
        {
            get
            {
                return singleInstance.Value;
            }
        }
        
        private string token = "";

        public void SetToken(string t) { token = t; }

        public string GetToken() { return token; }

        public ResponseToken Login(string username_, string password_)
        {
            var client = new RestClient(Program.API_ENDPOINT + "login");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            dynamic userObject = new { username = username_, password = password_ };
            request.AddJsonBody(SimpleJson.SerializeObject(userObject));
            return SimpleJson.DeserializeObject<ResponseToken>(client.Execute(request).Content);
        }
    }
}
