using NMoonraker.Interfaces;
using StreamJsonRpc;

namespace NMoonraker.Services
{
  public class WebSocketService : IWebSocketService
  {
    private readonly IKlippyApis klippyApis;

    public WebSocketService(IKlippyApis klippyApis)
    {
      this.klippyApis = klippyApis;
    }

    [JsonRpcMethod("printer.gcode.script")]
    public string RunGcode(string script)
    {
      return this.klippyApis.RunGcode(script) as string;
    }
  }
}
