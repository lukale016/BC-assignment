using System.Text.Json.Serialization;

namespace BCAsiggnment.Models;

public class Logos
{
    [JsonPropertyName("promo")]
    public string Promo { get; set; }
    
    [JsonPropertyName("primary")]
    public string Primary { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonPropertyName("betslip_carousel")]
    public string BetslipCarousel { get; set; }
}
