using System;
using System.Collections.Generic;
using System.Text;
using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.models.Nodes;
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
            //Arrange 
            var identifier = "Node1";
            string descriptor = "AND";

            //Act
            var factory = NodeFactory.Instance;
            var andNode = factory.CreateNode(identifier, descriptor);
            //Assert
            Assert.IsInstanceOfType(andNode, typeof(And));
        }


        [TestMethod]
        public void CheckValueOfCreatedInputNode()
        {

            var identifier = "Node1";
            string descriptor = "INPUT_HIGH";

            //Act
            var factory = NodeFactory.Instance;
            var inputNode = factory.CreateNode(identifier, descriptor);

            Assert.IsInstanceOfType(inputNode, typeof(Input));
            Assert.AreEqual(inputNode.Value, 1);

        }
    }

}
