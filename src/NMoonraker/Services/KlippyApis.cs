using NMoonraker.Interfaces;

namespace NMoonraker.Services
{
  public class KlippyApis : IKlippyApis
  {
    private readonly IKlippyConnection klippyConnection;

    public KlippyApis(IKlippyConnection klippyConnection)
    {
      this.klippyConnection = klippyConnection; 
    }

    public object RunGcode(string script)
    {
      throw new NotImplementedException();
    }
  }
}
