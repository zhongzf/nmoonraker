using NMoonraker.Interfaces;
using System.Net.Sockets;

namespace NMoonraker.Services
{
  public class KlippyConnection : IKlippyConnection
  {
    private string udsAddress;

    public KlippyConnection(IConfiguration configuration)
    {
      this.udsAddress = configuration.GetValue("klippy_uds_address", "/tmp/klippy_uds");
    }

    public void Connect()
    {
      using var socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
      var udsEndpoint = new UnixDomainSocketEndPoint(udsAddress);
      socket.Connect(udsEndpoint);
    }
  }
}
