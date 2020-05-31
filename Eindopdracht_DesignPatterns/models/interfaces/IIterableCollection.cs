using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.interfaces
{
    public interface IIterableCollection
    {
        IIterator CreateIterator();
    }
}
