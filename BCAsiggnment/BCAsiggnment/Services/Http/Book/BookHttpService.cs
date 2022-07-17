using System.Text.Json;

namespace BCAsiggnment.Services;

public class BookHttpService : HttpServiceBase, IBookHttpService
{
    private static BookHttpService instance;

    public static IBookHttpService Instance => instance ??= new BookHttpService();

    private BookHttpService() : base() 
    {}

    public async Task<IEnumerable<Book>> GetBooks()
    {
        using HttpResponseMessage response = await client.GetAsync($"{RouteConstants.BookRouteAppend}books");

        if (!response.IsSuccessStatusCode)
            return Enumerable.Empty<Book>();

        string jsonResponse = await response.Content.ReadAsStringAsync();

        BookArrayWrapper wrapper = JsonSerializer.Deserialize<BookArrayWrapper>(jsonResponse);

        if (wrapper is null || wrapper.Books is null)
            return Enumerable.Empty<Book>();
        return wrapper.Books;
    }
}
