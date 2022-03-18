using Microsoft.AspNetCore.Mvc;
using NMoonraker.Common.Models;
using NMoonraker.Interfaces;
using StreamJsonRpc;

namespace NMoonraker.Controllers
{
  [Route("websocket")]
  public class WebSocketController : ControllerBase
  {
    private readonly IWebSocketService _webSocketService;

    public WebSocketController(IWebSocketService webSocketService)
    {
      _webSocketService = webSocketService;
    }

    [HttpGet]
    public async Task Get()
    {
      if (HttpContext.WebSockets.IsWebSocketRequest)
      {
        using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();
        var jsonRpcMessageHandler = new WebSocketMessageHandler(webSocket);

        using (var jsonRpc = new JsonRpc(jsonRpcMessageHandler, _webSocketService))
        {
          jsonRpc.StartListening();

          await jsonRpc.Completion;
        }
      }
      else
      {
        HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
      }
    }
  }
}
