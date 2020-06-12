using Eindopdracht_DesignPatterns.models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers.Adapter_pattern
{
    public class JsonToListAdapter : IToListAdapter
    {
        public List<CircuitFile> ToList()
        {
            List<CircuitFile> items = new List<CircuitFile>();
            using (StreamReader r = new StreamReader(Path.Combine("C:/Projects/Eindopdracht_DesignPatterns/Eindopdracht_DesignPatterns/", @"data\", "CircuitNames.json")))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<CircuitFile>>(json);
            }
            return items;
        }
    }
}
