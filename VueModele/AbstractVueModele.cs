using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Wankul
{
    abstract class AbstractVueModele<E, R>
    {
        private string token = LoginService.SingleInstance.GetToken();

        protected abstract string GetApiUrl();

        protected R GET()
        {
            var client = new RestClient(Program.API_ENDPOINT + GetApiUrl());
            client.Timeout = -1;
            return SimpleJson.DeserializeObject<R>(client.Execute(new RestRequest(Method.GET)).Content);
        }

        protected R POST(E entity)
        {
            var client = new RestClient(Program.API_ENDPOINT + GetApiUrl());
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-AUTH-TOKEN", token);
            request.AddJsonBody(SimpleJson.SerializeObject(entity));
            return SimpleJson.DeserializeObject<R>(client.Execute(request).Content);
        }

        protected R PUT(E entity, int entityId)
        {
            var client = new RestClient(Program.API_ENDPOINT + GetApiUrl() + '/' + entityId);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("X-AUTH-TOKEN", token);
            request.AddJsonBody(SimpleJson.SerializeObject(entity));
            return SimpleJson.DeserializeObject<R>(client.Execute(request).Content);
        }

        protected R DELETE(int entityId)
        {
            var client = new RestClient(Program.API_ENDPOINT + GetApiUrl() + '/' + entityId);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("X-AUTH-TOKEN", token);
            return SimpleJson.DeserializeObject<R>(client.Execute(request).Content);
        }
    }
}
