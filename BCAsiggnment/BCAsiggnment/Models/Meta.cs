using System.Text.Json.Serialization;

namespace BCAsiggnment.Models;

public class Meta
{
    [JsonPropertyName("logos")]
    public Logos Logos { get; set; }

    [JsonPropertyName("states")]
    public List<string> States { get; set; }

    [JsonPropertyName("website")]
    public string Website { get; set; }

    [JsonPropertyName("deeplink")]
    public Deeplink Deeplink { get; set; }

    [JsonPropertyName("is_legal")]
    public bool IsLegal { get; set; }

    [JsonPropertyName("is_promoted")]
    public bool IsPromoted { get; set; }

    [JsonPropertyName("betsync_type")]
    public int BetsyncType { get; set; }

    [JsonPropertyName("is_preferred")]
    public bool IsPreferred { get; set; }

    [JsonPropertyName("primary_color")]
    public string PrimaryColor { get; set; }

    [JsonPropertyName("betsync_status")]
    public int BetsyncStatus { get; set; }

    [JsonPropertyName("secondary_color")]
    public string SecondaryColor { get; set; }

    [JsonPropertyName("is_fastbet_enabled_app")]
    public bool IsFastbetEnabledApp { get; set; }

    [JsonPropertyName("is_fastbet_enabled_web")]
    public bool IsFastbetEnabledWeb { get; set; }
}
