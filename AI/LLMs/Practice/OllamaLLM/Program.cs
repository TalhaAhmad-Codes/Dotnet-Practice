using Microsoft.Extensions.DependencyInjection;
using OllamaLLM.Services.Implementation;
using OllamaLLM.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using OllamaSharp;

var builder = Host.CreateApplicationBuilder(args);

// Register Ollama client
Console.WriteLine("\nConnecting...");
builder.Services.AddSingleton(new OllamaApiClient(new Uri("http://localhost:11434"))
{
    SelectedModel = "llama3"
});

// Register your service
// 1. Install Ollama on your system: irm https://ollama.com/install.ps1 | iex
// 2. Run server: ollama serve
Console.WriteLine("\nBuilding...");
builder.Services.AddSingleton<IChatService, ChatService>();

var app = builder.Build();

// Resolve and run
var chatService = app.Services.GetRequiredService<IChatService>();

Console.Write("\nPrompt: ");
var prompt = Console.ReadLine();

if (prompt != null)
{
    Console.WriteLine("\nGetting Response...");
    var result = await chatService.AskAsync(prompt);

    Console.WriteLine("\nThe Response:");
    Console.WriteLine(result);
}

Console.WriteLine("\nGoody Bye... ;-)");
