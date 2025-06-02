using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AgentTextWebApp.Pages
{
    public class AskAgentModel : PageModel
    {
        [BindProperty]
        public string Question { get; set; }
        public string Answer { get; set; }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrWhiteSpace(Question))
            {
                ModelState.AddModelError("Question", "Please enter a question.");
                return Page();
            }

            using var client = new HttpClient();
            var content = new StringContent(
                JsonSerializer.Serialize(new { question = Question }),
                Encoding.UTF8,
                "application/json"
            );

            // Adjust the URL/port if needed
            var response = await client.PostAsync("https://localhost:5001/api/questions", content);
            if (response.IsSuccessStatusCode)
            {
                Answer = await response.Content.ReadAsStringAsync();
            }
            else
            {
                Answer = "Error: Unable to get a response from the agent.";
            }

            return Page();
        }
    }
}