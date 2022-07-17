
namespace BCAsiggnment.Services;

public interface IBookHttpService
{
    Task<IEnumerable<Book>> GetBooks();
}
