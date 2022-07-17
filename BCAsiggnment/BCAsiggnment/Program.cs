using BCAsiggnment.Constants;
using BCAsiggnment.Services;
using System.Text;

var bookHttpService = BookHttpService.Instance;

var books = await bookHttpService.GetBooks();

var fileService = FileService.Instance;

await fileService.WriteToFileGrouped<string, Book>(books.Where(b => b.ParentName is not null && b.Meta is not null && b.Meta.States is not null && (b.Meta.States.Contains(StateCodeConsts.NewJersey) || b.Meta.States.Contains(StateCodeConsts.Colorado))).GroupBy(b => b.ParentName).OrderBy(b => b.Key), (Book book) =>
{
    if (book is null)
        return string.Empty;
    
    StringBuilder sb = new();
    sb.Append($"\t{book.DisplayName}: ");
    
    foreach(var state in book.Meta.States)
    {
        sb.Append($"{state} ");
    }
    return sb.ToString();
});
