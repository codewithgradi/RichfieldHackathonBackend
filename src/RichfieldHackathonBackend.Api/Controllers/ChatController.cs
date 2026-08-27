using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.AI;

namespace RichfieldHackathonBackend.Api.Controller;

[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly IChatClient _chatClient;
    private readonly McpToolsRegistery _toolRegistery;
    private readonly ILogger<ChatController> _logger;

    public ChatController(
        IChatClient chatClient,
        McpToolsRegistery registery,
        ILogger<ChatController> logger
         )
    {
        _chatClient = chatClient;
        _toolRegistery = registery;
        _logger = logger;
    }
    [HttpPost("{userID:int}")]
    public async Task<IActionResult> Chat(
        [FromRoute] int userID,
        [FromBody] ChatRequestDto request,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Message))
        {
            return BadRequest(new ChatResponseDto(
                Success: false,
                Reply: null,
                Error: "Message prompt cannot be empty."
            ));
        }

        List<ChatMessage> conversation = new()
        {
            new ChatMessage(ChatRole.System, $"""
                You are the system's AI assistant integrated with personal MCP tools.
                ALWAYS check and call your available tools (

                ) before answering questions.
                
                CRITICAL INSTRUCTION:
                There are 4 types of roles each user has.
                A user can an admin, business, student, alumni.
                The roles will be found through the user's table under the field UserRole.
                When choosing a tool always check the type role the user has and
                use the tool.
                When a user for example business does not have access to tools due to their role
                return a friendly message saying telling them that they do not have such access.
                The current active user ID is {userID}.
                Whenever you call any tool that accepts a userID parameter, you MUST pass {userID} as the userID argument.
                Never query data without scoping it to userId ID {userID}.
                To insure that the user exists
                Do not mention what tool you used or the company id in your renspose.
                In your response do not in clude special charaters.
                """),
            new ChatMessage(ChatRole.User, request.Message)
        };

        var chatOptions = new ChatOptions
        {
            Tools = _toolRegistery.GetAITools()
        };

        ChatResponse response = await _chatClient.GetResponseAsync(
            conversation,
            chatOptions,
            cancellationToken
        );

        _logger.LogInformation("Chat completion successful.");

        return Ok(new ChatResponseDto(
            Success: true,
            Reply: response.Text,
            Error: null
        ));
    }
}