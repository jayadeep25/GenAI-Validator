namespace LLM_Validator.Models
{
    public class LlmRequest
    {
        public string Provider { get; set; } // "openai" or "gemini"
        public string Prompt { get; set; }
    }
}
