namespace LLM_Validator.Services
{
    public interface ILlmService
    {
        Task<string> GetResponseAsync(string prompt);
    }
}
