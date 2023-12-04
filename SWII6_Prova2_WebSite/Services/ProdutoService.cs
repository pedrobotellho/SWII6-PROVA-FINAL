using Newtonsoft.Json;
using SWII6_Prova2_WebSite.Models;
using System.Net;

namespace SWII6_Prova2_WebSite.Services
{
    public class ProdutoService
    {
        private static ProdutoService Instance;
        private static LoginService _loginService;

        public static ProdutoService getInstance()
        {
            if (Instance == null)
            {
                Instance = new ProdutoService();
            }

            return Instance;
        }

        private string baseURL;

        private ProdutoService()
        {
            baseURL = "http://localhost:5058";
            _loginService = LoginService.getInstance();
        }

        public async Task<ProdutoModel> Get(int id)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/produtos/{id}");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var produto = JsonConvert.DeserializeObject<ProdutoModel>(await response.Content.ReadAsStringAsync());

            return produto;
        }

        public async Task<List<ProdutoModel>> GetAll()
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseURL}/produtos");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var produtos = JsonConvert.DeserializeObject<List<ProdutoModel>>(await response.Content.ReadAsStringAsync());

            return produtos;
        }

        public async Task<bool> Create(ProdutoModel model)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseURL}/produtos");

            model.IdUsuarioCadastro = _loginService.UsuarioId;
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

            var request = new HttpRequestMessage(HttpMethod.Delete, $"{baseURL}/produtos/{id}");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            await response.Content.ReadAsStringAsync();

            return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<bool> Update(ProdutoModel model)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Put, $"{baseURL}/produtos/{model.Id}");

            model.IdUsuarioUpdate = _loginService.UsuarioId;
            var content = JsonConvert.SerializeObject(model);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            await response.Content.ReadAsStringAsync();

            return response.StatusCode == HttpStatusCode.NoContent;
        }
    }
}
