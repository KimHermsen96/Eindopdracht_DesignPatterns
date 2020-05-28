using DotBuilder;
using DotBuilder.Attributes;
using DotBuilder.Statements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.Graphviz
{
    public class Experiment2
    {
        public GraphBase NewGraph { get; private set; }

        public Experiment2()
        {
            InitGraph();
        }

        public void InitGraph()
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
            if (label == "1")
            {
                NewGraph.Containing(Edge.Between(fromName, toName).WithAttributesOf(Label.Set(label), Color.Green));
            }
            else if (label == "0")
            {
                NewGraph.Containing(Edge.Between(fromName, toName).WithAttributesOf(Label.Set(label), Color.Red));
            }
            else
            {
                NewGraph.Containing(Edge.Between(fromName, toName).WithAttributesOf(Label.Set(label)));
            }
        }

        public void AddEdge(Statement<Edge, IEdgeAttribute> edge)
        {
            NewGraph.Containing(edge);
        }

        public void AddNode(Statement<Node, INodeAttribute> node)
        {
            NewGraph.Containing(node);
        }

        public void AddNode(string name, string type)
        {
            if (type != "Input" && type != "Output")
            {
                NewGraph.Containing(Node.Name(name).WithAttributesOf(Label.Set(type)));
            }
            else
            {
                NewGraph.Containing(Node.Name(name).WithAttributesOf(Shape.Plaintext));
            }
        }

        public string Render(string graphvizdir = "bin/", string outputdir = null)
        {
            // to render to a file stream
            var gv = new GraphViz(graphvizdir, OutputFormat.Png);

            string path;

            if (outputdir == null)
                path = outputdir + Guid.NewGuid().ToString() + ".png";
            else
                path = outputdir + Guid.NewGuid().ToString() + ".png";

            using (var stream = new FileStream(path, FileMode.Create))
            {
                gv.RenderGraph(NewGraph, stream);
            }
            return path;
        }
    }
}
