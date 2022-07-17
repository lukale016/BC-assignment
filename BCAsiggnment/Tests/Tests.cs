using BCAsiggnment.Models;
using BCAsiggnment.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        private IFileService fileService;

        [SetUp]
        public void Setup()
        {
            fileService = FileService.Instance;
        }

        [Test]
        public async Task Test()
        {
            var list = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    DisplayName = "Test"
                }
            };

            await fileService.WriteToFileGrouped<int, Book>(list.GroupBy(b => b.Id), (Book book) => $"{book.DisplayName}");

            string fileContent = ReadFromFile();

            Assert.That(fileContent == $"{list[0].Id}:{Environment.NewLine}{list[0].DisplayName}{Environment.NewLine}");
        }

        private string ReadFromFile()
        {
            string result = string.Empty;
            Directory.SetCurrentDirectory(PathConstants.ResultPath);
            using (var fs = File.OpenRead("result.txt"))
            {
                Directory.SetCurrentDirectory(PathConstants.ParentDir);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                result = Encoding.UTF8.GetString(bytes);
            }
            return result;
        }
    }
}