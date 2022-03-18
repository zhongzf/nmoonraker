using Microsoft.AspNetCore.Mvc;
using NMoonraker.Common.Models;
using NMoonraker.Interfaces;

namespace NMoonraker.Controllers
{
  [ApiController]
  [Route("access")]
  public class AccessController : ControllerBase
  {
    [HttpGet("oneshot_token")]
    public Token GetOneshotToken()
    {
      return new Token { Result = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX" };
    }
  }
}
