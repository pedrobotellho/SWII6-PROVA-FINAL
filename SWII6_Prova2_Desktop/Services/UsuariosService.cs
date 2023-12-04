using Newtonsoft.Json;
using SWII6_Prova2_Desktop.Models;
using System.Net;

namespace SWII6_Prova2_Desktop
{
    public class UsuariosService
    {
        private static UsuariosService Instance;

        public static UsuariosService getInstance()
        {
            if(Instance == null)
            {
                Instance = new UsuariosService();
            }

            return Instance;
        }

        private string baseURL;
        private UsuariosService()
        {
            baseURL = "http://localhost:5058";
        }

        public async Task<UsuarioModel> Get(int id)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/usuarios/{id}");


            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var carro = JsonConvert.DeserializeObject<UsuarioModel>(await response.Content.ReadAsStringAsync());

            return carro;
        }

        public async Task<List<UsuarioModel>> GetAll()
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/usuarios");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            
            var usuarios = JsonConvert.DeserializeObject<List<UsuarioModel>>(await response.Content.ReadAsStringAsync());

            return usuarios;
        }

        public async Task<bool> Create(UsuarioModel model)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseURL}/usuarios");

            var content = JsonConvert.SerializeObject(model);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            await response.Content.ReadAsStringAsync();

            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task<bool> Delete(int id)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Delete, $"{baseURL}/usuarios/{id}");


            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            await response.Content.ReadAsStringAsync();

            return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<bool> Update(UsuarioModel model)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Put, $"{baseURL}/usuarios/{model.Id}");

            var content = JsonConvert.SerializeObject(model);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            await response.Content.ReadAsStringAsync();

            return response.StatusCode == HttpStatusCode.NoContent;
        }
    }
}
