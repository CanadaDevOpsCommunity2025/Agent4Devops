using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AgentTextWebApp.Models;

namespace AgentTextWebApp.Services
{
    public class AgentTextService
    {
        private readonly HttpClient _httpClient;
        private readonly string _agentTextApiUrl;

        public AgentTextService(HttpClient httpClient, string agentTextApiUrl)
        {
            _httpClient = httpClient;
            _agentTextApiUrl = agentTextApiUrl;
        }

        public async Task<string> SendQuestion(QuestionRequest request)
        {
            var jsonRequest = JsonSerializer.Serialize(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_agentTextApiUrl, content);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return jsonResponse;
        }
    }
}