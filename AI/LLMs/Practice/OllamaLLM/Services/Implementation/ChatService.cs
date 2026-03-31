using OllamaSharp;
using OllamaLLM.Services.Interfaces;

namespace OllamaLLM.Services.Implementation
{
    public class ChatService : IChatService
    {
        private readonly OllamaApiClient _client;

        public ChatService(OllamaApiClient client)
        {
            _client = client;
        }

        public async Task<string> AskAsync(string prompt)
        {
            var result = "";

            await foreach (var chunk in _client.GenerateAsync(prompt))
            {
                if (chunk != null)
                {
                    result += chunk.Response;
                }
            }

            return result;
        }
    }
}
