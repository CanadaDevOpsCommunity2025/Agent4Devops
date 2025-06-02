using Microsoft.AspNetCore.Mvc;
using AgentTextWebApp.Models;
using AgentTextWebApp.Services;
using System.Threading.Tasks;

namespace AgentTextWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly AgentTextService _agentTextService;

        public QuestionsController(AgentTextService agentTextService)
        {
            _agentTextService = agentTextService;
        }

        [HttpPost]
        public async Task<IActionResult> PostQuestion([FromBody] QuestionRequest questionRequest)
        {
            if (questionRequest == null || string.IsNullOrWhiteSpace(questionRequest.Question))
            {
                return BadRequest("Invalid question request.");
            }

            var response = await _agentTextService.SendQuestion(questionRequest);
            return Ok(response);
        }
    }
}