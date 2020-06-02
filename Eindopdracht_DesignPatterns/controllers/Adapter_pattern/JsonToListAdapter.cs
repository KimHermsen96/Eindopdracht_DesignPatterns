using Eindopdracht_DesignPatterns.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.Adapter_pattern
{
    public class JsonToListAdapter
    {
        public List<CircuitFile> ToList()
        {
            List<CircuitFile> items = new List<CircuitFile>();
            using (StreamReader r = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"data\", "CircuitNames.json")))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<CircuitFile>>(json);
            }
            return items;
        }
    }
}
