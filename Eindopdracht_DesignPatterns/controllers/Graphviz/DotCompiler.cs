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

namespace Eindopdracht_DesignPatterns.controllers.Graphviz
{
    public class DotCompiler
    {

        public DotCompiler()
        {

            bla();
        }

        public async Task bla()
        {

            Graph graph = Graph.Undirected
              .Add(EdgeStatement.For("a", "b"))
              .Add(EdgeStatement.For("a", "c"));

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
