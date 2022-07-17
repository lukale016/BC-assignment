
using System.Text;

namespace BCAsiggnment.Services;

public class FileService : IFileService
{
    private static IFileService instance;

    public static IFileService Instance => instance ??= new FileService();

    private FileService()
    {
        if(!Directory.Exists(PathConstants.ResultPath))
        {
            Directory.CreateDirectory(PathConstants.ResultPath);
        }
    }

    public async Task WriteToFileGrouped<TGrouped, TEntity>(IEnumerable<IGrouping<TGrouped, TEntity>> groups, Func<TEntity, string> writeFormat)
    {
        StringBuilder contentBuilder = new();
        foreach(var group in groups)
        {
            contentBuilder.AppendLine($"{group.Key}:");
            foreach(var entity in group)
            {
                contentBuilder.AppendLine(writeFormat(entity));
            }
        }

        Directory.SetCurrentDirectory(PathConstants.ResultPath);
        using (var fs = File.OpenWrite("result.txt"))
        {
            await fs.WriteAsync(Encoding.UTF8.GetBytes(contentBuilder.ToString()), 0, contentBuilder.Length);
        }
        Directory.SetCurrentDirectory(PathConstants.ParentDir);
    }
}
