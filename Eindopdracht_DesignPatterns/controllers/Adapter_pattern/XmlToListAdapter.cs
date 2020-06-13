using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CircuitLogic.models;
using CircuitLogic.models.interfaces;

namespace CircuitLogic.controllers.Adapter_pattern
{
    public class XmlToListAdapter : IToListAdapter
    {
        public List<CircuitFile> ToList()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:/Projects/Eindopdracht_DesignPatterns/Eindopdracht_DesignPatterns/data/CircuitNames.xml");

            var list = new List<CircuitFile>();
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var file = new CircuitFile()
                {
                    Name = node.ChildNodes[0]?.InnerText,
                    Location = node.ChildNodes[1]?.InnerText
                };

                list.Add(file);
            }

            return list;
        }
    }
}
