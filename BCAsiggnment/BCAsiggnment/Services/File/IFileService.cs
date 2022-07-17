
namespace BCAsiggnment.Services;

public interface IFileService
{
    Task WriteToFileGrouped<TGrouped, TEntity>(IEnumerable<IGrouping<TGrouped, TEntity>> groups, Func<TEntity, string> writeFormat);
}
