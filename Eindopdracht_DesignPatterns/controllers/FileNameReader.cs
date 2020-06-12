using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.Adapter_pattern;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class FileNameReader
    {

        public string GetName()
        {

            var x = new JsonToListAdapter();
            var b = x.ToList();
            return "hoi";
        }
    }
}
