using Microsoft.AspNetCore.Mvc;
using NMoonraker.Common.Models;
using NMoonraker.Interfaces;

namespace NMoonraker.Controllers
{
  [ApiController]
  [Route("server")]
  public class ServerController : ControllerBase
  {
    private readonly ILogger<ServerController> _logger;
    private readonly IServerService _serverService;

    public ServerController(ILogger<ServerController> logger, IServerService serverService)
    {
      _logger = logger;
      _serverService = serverService;
    }

    [HttpGet("info")]
    public ServerInfo Info()
    {
      return _serverService.GetServerInfo();
    }

    [HttpGet("database/item")]
    public ApiResponse GetDatabaseItem()
    {
      var databaseItem = _serverService.GetDatabaseItem();
      var apiResponse = new ApiResponse
      {
        Result = databaseItem
      };
      return apiResponse;
    }
  }
}