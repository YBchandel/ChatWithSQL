using Microsoft.AspNetCore.Mvc;
using AIChat.API.Interfaces;
using AIChat.API.Models;

namespace AIChat.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost]
        public async Task<IActionResult> Chat([FromBody] ChatRequest request)
        {
            var response = await _chatService.ProcessMessageAsync(request);

            return Ok(response);
        }
    }
}