using System.Text.Json;
using System.Text.Json.Serialization;

namespace NMoonraker.Common.Models
{
  public class ServerInfo
  {
    [JsonPropertyName("klippy_connected")]
    public bool KlippyConnected { get; set; }

    [JsonPropertyName("klippy_state")]
    public string KlippyState { get; set; }

    [JsonPropertyName("components")]
    public List<string> Components { get; set; }

    [JsonPropertyName("failed_components")]
    public List<object> FailedComponents { get; set; }

    [JsonPropertyName("registered_directories")]
    public List<string> RegisteredDirectories { get; set; }

    [JsonPropertyName("warnings")]
    public List<string> Warnings { get; set; }

    [JsonPropertyName("websocket_count")]
    public long WebsocketCount { get; set; }

    [JsonPropertyName("moonraker_version")]
    public string MoonrakerVersion { get; set; }
  }
}
