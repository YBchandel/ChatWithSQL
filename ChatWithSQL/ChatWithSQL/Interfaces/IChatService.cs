using AIChat.API.Models;

namespace AIChat.API.Interfaces
{
    public interface IChatService
    {
        Task<ChatResponse> ProcessMessageAsync(ChatRequest request);
    }
}