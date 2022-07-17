using System.Text.Json.Serialization;

namespace BCAsiggnment.Models;

public class Book
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; }

    [JsonPropertyName("abbr")]
    public string Abbr { get; set; }

    [JsonPropertyName("source_name")]
    public string SourceName { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    [JsonPropertyName("parent_name")]
    public string ParentName { get; set; }

    [JsonPropertyName("book_parent_id")]
    public int? BookParentId { get; set; }

    [JsonPropertyName("affiliate_id")]
    public int? AffiliateId { get; set; }
}
