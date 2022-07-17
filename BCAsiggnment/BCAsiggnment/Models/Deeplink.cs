
using System.Text.Json.Serialization;

namespace BCAsiggnment.Models;

public class Deeplink
{
    [JsonPropertyName("has_multi")]
    public bool HasMulti { get; set; }

    [JsonPropertyName("is_supported")]
    public bool IsSupported { get; set; }
}
