using Newtonsoft.Json;
using SWII6_Prova2_WebSite.Models;
using System.Net;

namespace SWII6_Prova2_WebSite.Services
{
    public class LoginService
    {
        private static LoginService Instance;
        public int UsuarioId { get; set; }

        public static LoginService getInstance()
        {
            if (Instance == null)
            {
                Instance = new LoginService();
            }

            return Instance;
        }

        private string baseURL;

        private LoginService()
        {
            baseURL = "http://localhost:5058";
        }

        public async Task<int> Logar(UsuarioModel model)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseURL}/login");

            var content = JsonConvert.SerializeObject(model);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var usuario = JsonConvert.DeserializeObject<ProdutoModel>(await response.Content.ReadAsStringAsync());

            return usuario?.Id ?? 0;
        }
    }
}
