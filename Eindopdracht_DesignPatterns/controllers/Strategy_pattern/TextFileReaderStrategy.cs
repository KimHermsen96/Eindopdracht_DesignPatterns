using Eindopdracht_DesignPatterns.models.interfaces;
using System.IO;
using System.Reflection;

namespace Eindopdracht_DesignPatterns.controllers.Strategy_pattern
{
    public class TextFileReaderStrategy : IFileReaderStrategy
    {
        public string[] Readfile(string file)
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                @"data\" + file);
            string[] files = File.ReadAllLines(path);
            return files;
        }
    }
}
