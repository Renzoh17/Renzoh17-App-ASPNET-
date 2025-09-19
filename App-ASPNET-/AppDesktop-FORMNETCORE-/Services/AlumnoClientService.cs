using AppDesktop_FORMNETCORE_.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDesktop_FORMNETCORE_.Services
{
    internal class AlumnoClientService
    {
        RestClient client = new("http://localhost:5056/api/");

        public async Task<List<Alumno>?> GetAll()
        {
            var request = new RestRequest("Alumno", Method.Get);
            var response = await client.ExecuteAsync<List<Alumno>>(request);
            List<Alumno>? als = null;
            if (response.IsSuccessful && response.Data != null)
            {
                als = response.Data;
            }
            return als;
        }

        public async Task<Alumno?> GetById(int id)
        {
            var request = new RestRequest("Alumno/{id}", Method.Get);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteAsync<Alumno>(request);
            Alumno? a = null;
            if (response.IsSuccessful && response.Data != null)
            {
                a = response.Data;
            }
            return a;
        }

        public async Task<int> Post(Alumno a)
        {
            int createdId = 0;
            var request = new RestRequest("Alumno", Method.Post);
            request.AddJsonBody(a);
            var response = await client.ExecuteAsync<int>(request);

            if (response.IsSuccessful)
            {
                createdId = response.Data;
            }
            return createdId;
        }

        public async Task<bool> Update(Alumno a)
        {
            var request = new RestRequest("Alumno/{id}", Method.Put);
            request.AddUrlSegment("id", a.Id);
            request.AddJsonBody(a);
            var response = await client.ExecuteAsync(request);

            return response.IsSuccessful;
        }

        public async Task<bool> Delete(int id)
        {
            var request = new RestRequest("Alumno/{id}", Method.Delete);
            request.AddUrlSegment("id", id);
            var response = await client.ExecuteAsync(request);

            return response.IsSuccessful;
        }
    }
}
