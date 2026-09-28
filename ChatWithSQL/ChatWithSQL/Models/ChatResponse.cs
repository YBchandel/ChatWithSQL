namespace AIChat.API.Models
{
    public class ChatResponse
    {
        public string Message { get; set; } = string.Empty;

        public bool Success { get; set; }

        public DateTime Timestamp { get; set; }
    }
}