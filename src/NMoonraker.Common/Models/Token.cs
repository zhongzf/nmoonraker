using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NMoonraker.Common.Models
{
  public class Token
  {
    [JsonPropertyName("result")]
    public string Result { get; set; }
  }
}
