using NMoonraker.Common.Models;
using NMoonraker.Interfaces;

namespace NMoonraker.Services
{
  public class ServerService : IServerService
  {
    public ServerInfo GetServerInfo()
    {
      var serverInfo = new ServerInfo();
      serverInfo.KlippyConnected = true;      
      return serverInfo;
    }

    public DatabaseItem GetDatabaseItem()
    {
      var databaseItem = new DatabaseItem();
      databaseItem.Namespace = "fluidd";
      return databaseItem;
    }
  }
}
