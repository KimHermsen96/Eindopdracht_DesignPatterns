using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    class FileReader
    {
        public string[] Readfile(string file)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                @"data\" + file);
            string[] files = File.ReadAllLines(path);
//            foreach (var f in files) Console.WriteLine(f);
//            Console.ReadKey();
            return files;
        }
    }
}
