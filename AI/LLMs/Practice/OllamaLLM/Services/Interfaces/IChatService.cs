namespace OllamaLLM.Services.Interfaces
{
    public interface IChatService
    {
        Task<string> AskAsync(string prompt);
    }
}
