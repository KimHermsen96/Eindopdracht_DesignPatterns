using Shields.GraphViz.Components;
using Shields.GraphViz.Models;
using Shields.GraphViz.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CircuitLogic.controllers.Graphviz
{
    public class DotCompiler
    {

        public DotCompiler()
        {
            bla();
        }

        public async Task bla()
        {

            Graph graph = Graph.Directed
              .Add(EdgeStatement.For("Cin", "Node3"))
              .Add(EdgeStatement.For("Cin", "Node7"))
              .Add(EdgeStatement.For("Cin", "Node10"))
              .Add(EdgeStatement.For("A", "Node1"))
              .Add(EdgeStatement.For("A", "Node2"))
              .Add(EdgeStatement.For("B", "Node1"))
              .Add(EdgeStatement.For("B", "Node2"))
              .Add(EdgeStatement.For("Node1", "Node3"))
              .Add(EdgeStatement.For("Node1", "Node5"))
              .Add(EdgeStatement.For("Node2", "Node4"))
              .Add(EdgeStatement.For("Node2", "Node6"))
              .Add(EdgeStatement.For("Node3", "Node6"))
              .Add(EdgeStatement.For("Node4", "Node5"))
              .Add(EdgeStatement.For("Node5", "Node8"))
              .Add(EdgeStatement.For("Node5", "Node9"))
              .Add(EdgeStatement.For("Node6", "Cout"))
              .Add(EdgeStatement.For("Node7", "Node9"))
              .Add(EdgeStatement.For("Node8", "Node10"))
              .Add(EdgeStatement.For("Node9", "Node11"))
              .Add(EdgeStatement.For("Node10", "Node11"))
              .Add(EdgeStatement.For("Node11", "S"));

            IRenderer renderer = new Renderer("bin/");
            using (Stream file = File.Create("graph.png"))
            {
                await renderer.RunAsync(
                    graph, file,
                    RendererLayouts.Dot,
                    RendererFormats.Png,
                    CancellationToken.None);
            }
        }
  
    }
}
