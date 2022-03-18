using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NMoonraker.Common.Models
{
  public class DatabaseItem
  {
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("value")]
    public object Value { get; set; }
  }
}
