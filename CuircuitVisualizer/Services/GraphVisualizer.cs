using System;
using System.IO;
using DotBuilder;
using DotBuilder.Attributes;
using DotBuilder.Statements;

namespace CuircuitVisualizer.Services
{
    public class GraphVisualizer
    {

        public GraphBase NewGraph { get; private set; }

        public GraphVisualizer()
        {
            NewGraph = Graph.Directed("test")
                .WithGraphAttributesOf(
                    RankDir.LR,
                    Font.Name("Arial"),
                    Font.Size(55))
                .WithNodeAttributesOf(
                    Style.Rounded,
                    Style.Filled,
                    Shape.Rectangle,
                    Color.Black,
                    FillColor.White);
        }

        public void AddEdge(string fromName, string toName, string label = null)
        {
            NewGraph.Containing(Edge.Between(fromName, toName).WithAttributesOf(Label.Set(label)));

        }

        public void AddNode(string name, string type)
        {

            NewGraph.Containing(Node.Name(name).WithAttributesOf(Label.Set(type)));

        }

        //Save image
        public void Render()
        {
            var gv = new GraphViz("bin/", OutputFormat.Png);
            string path = "currentImg" + ".png";
        
            using (var stream = new FileStream(path, FileMode.Create))
            {
                gv.RenderGraph(NewGraph, stream);
            }
        }
    }
}
