using System.Text.Json.Serialization;

namespace BCAsiggnment.Wrapers;

public class BookArrayWrapper
{
    [JsonPropertyName("books")]
    public List<Book> Books { get; set; }
};