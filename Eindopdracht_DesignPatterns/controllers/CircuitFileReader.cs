using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CircuitLogic.controllers
{
    public class CircuitFileReader
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
