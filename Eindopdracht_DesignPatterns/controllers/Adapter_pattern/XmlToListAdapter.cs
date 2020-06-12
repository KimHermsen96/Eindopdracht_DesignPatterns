using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers.Adapter_pattern
{
    public class XmlToListAdapter : IToListAdapter
    {
        public List<CircuitFile> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
