using NMoonraker.Common.Models;

namespace NMoonraker.Interfaces
{
  public interface IServerService
  {
    ServerInfo GetServerInfo();
    DatabaseItem GetDatabaseItem();
  }
}
