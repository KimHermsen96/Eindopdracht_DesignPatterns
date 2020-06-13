using CircuitLogic.controllers;
using CircuitLogic.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests
{
    [TestClass]
    public class FactoryTests
    {

        [TestMethod]
        public void FactoryInstance_IsNotNull()
        {
            Assert.IsNotNull(NodeFactory.Instance);
        }

        [TestMethod]
        public void CreateRightNode_FromString()
        {
            var identifier = "Node1";
            string descriptor = "AND";

            var factory = NodeFactory.Instance;
            var andNode = factory.CreateNode(identifier, descriptor);
            Assert.IsInstanceOfType(andNode, typeof(And));
        }


        [TestMethod]
        public void CheckValue_OfCreatedInputNode()
        {

            var identifier = "Node1";
            string descriptor = "INPUT_HIGH";

            var factory = NodeFactory.Instance;
            var inputNode = factory.CreateNode(identifier, descriptor);

            Assert.IsInstanceOfType(inputNode, typeof(Input));
            Assert.AreEqual(inputNode.Value, 1);

        }
    }

}
