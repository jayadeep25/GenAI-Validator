using Microsoft.AspNetCore.Mvc;
using LLM_Validator.Models;
using LLM_Validator.Services;

namespace LLM_Validator.Controllers
{
    public class HomeController : Controller
    {
        private readonly OpenAIService _openAI;
        private readonly GeminiService _gemini;

        public HomeController(OpenAIService openAI, GeminiService gemini)
        {
            _openAI = openAI;
            _gemini = gemini;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Chat([FromBody] LlmRequest request)
        {
            string response;

            if (request.Provider == "gemini")
                response = await _gemini.GetResponseAsync(request.Prompt);
            else
                response = await _openAI.GetResponseAsync(request.Prompt);

            return Json(new { result = response });
        }
    }
}
