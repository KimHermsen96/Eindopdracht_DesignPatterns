using Eindopdracht_DesignPatterns.controllers.Adapter_pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class ViewDataProvider
    {
        public List<string> FileNames { get; private set; }
        public Dictionary<string, int> AllNodes { get; private set; }
        public Dictionary<string, int> InputNodes { get; private set; }

        public List<string> GetFileNames()
        {
            //JsonToListAdapter listadapter = new JsonToListAdapter();
            //var FileMetadata = listadapter.ToList();
            //FileMetadata.ForEach(n => FileNames.Add(n.Name));

            FileNames = new List<string>() {
                 "file 1", "file 2", "file 3", "file 4"
            };

            return FileNames; 
        }

        public void GetAllNodes(Dictionary<string, int> _nodes)
        {


            AllNodes = _nodes; 
        }

        public void GetInputNodes(Dictionary<string, int> _nodes)
        {


            AllNodes = _nodes;
        }
    }
}
