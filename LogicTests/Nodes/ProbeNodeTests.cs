using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests.Nodes
{
    [TestClass]
    public class ProbeNodeTests
    {

        [TestMethod]
        public void ProbeNode_hasCorrectOuput_whenInputIs_1()
        {

            Probe probe = new Probe();
            probe.CalculateOutput(1);
            Assert.AreEqual(1, probe.Value);
        }

        [TestMethod]
        public void ProbeNode_hasCorrectOuput_whenInputIs_0()
        {

            Probe probe = new Probe();
            probe.CalculateOutput(0);
            Assert.AreEqual(0, probe.Value);
        }


        [TestMethod]
        public void ProbeNode_IsValidNode()
        {

            Probe probe = new Probe();
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(true, probe.Accept(visitor));
        }

    }
}
