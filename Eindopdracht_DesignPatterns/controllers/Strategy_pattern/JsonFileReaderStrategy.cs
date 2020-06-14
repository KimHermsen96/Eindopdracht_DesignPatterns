using Eindopdracht_DesignPatterns.models.interfaces;
using System.IO;
using System.Reflection;

namespace Eindopdracht_DesignPatterns.controllers.Strategy_pattern
{
    public class JsonFileReaderStrategy : IFileReaderStrategy
    {
        public string[] Readfile(string file)
        {
            //Insert code to convert Json file to validatable stringarray. 
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
              @"data\" + file);
            string[] files = File.ReadAllLines(path);
            return files;
        }
    }
}
