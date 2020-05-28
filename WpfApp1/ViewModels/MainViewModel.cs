using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;

namespace WpfApp1.ViewModels
{
    public class MainViewModel 
    {
        private IBidirectionalGraph<object, IEdge<object>> GraphtoVisualize { get; set; } 


        public MainViewModel()
        {
            CreateGraph();
        }

        private void CreateGraph()
        {
            //BidirectionAdapterGraph<object, IEdge<object>> g = new BidirectionalGraph<object, IEdge<object>>();


            //g.AddEdge();     
        }
    }
}
