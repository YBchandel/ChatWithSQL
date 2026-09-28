using AIChat.API.Interfaces;
using AIChat.API.Models;

namespace AIChat.API.Services
{
    public class ChatService : IChatService
    {
        private readonly IChatRepository _chatRepository;

        public ChatService(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public async Task<ChatResponse> ProcessMessageAsync(ChatRequest request)
        {
            // AI processing will come here later

            return new ChatResponse
            {
                Message = $"You asked: {request.Message}",
                Success = true,
                Timestamp = DateTime.UtcNow
            };
        }
    }
}