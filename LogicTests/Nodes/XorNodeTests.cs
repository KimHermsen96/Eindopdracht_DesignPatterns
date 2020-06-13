using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests.Nodes
{
    [TestClass]
    public class XorNodeTests
    {
        [TestMethod]
        public void XorNode_hasCorrectOuput_whenInputsAre_0And1()
        {

            Xor xor = new Xor()
            {
                NumberOfInputNodes = 2
            };
            xor.CalculateOutput(0);
            xor.CalculateOutput(1);

            Assert.AreEqual(1, xor.Value);
        }

        [TestMethod]
        public void XorNode_hasCorrectOuput_whenInputsAre_1And1()
        {

            Xor xor = new Xor()
            {
                NumberOfInputNodes = 2
            };
            xor.CalculateOutput(1);
            xor.CalculateOutput(1);

            Assert.AreEqual(0, xor.Value);
        }

        [TestMethod]
        public void XorNode_hasCorrectOuput_whenInputsAre_0And0()
        {

            Xor xor = new Xor()
            {
                NumberOfInputNodes = 2
            };
            xor.CalculateOutput(0);
            xor.CalculateOutput(0);

            Assert.AreEqual(0, xor.Value);
        }
        [TestMethod]
        public void XorNode_IsValidNode()
        {
            Xor xor = new Xor()
            {
                NumberOfInputNodes = 2
            };
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(true, xor.Accept(visitor));
        }
        [TestMethod]
        public void XorNode_IsInValidNode()
        {
            Xor xor = new Xor()
            {
                NumberOfInputNodes = 1
            };
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(false, xor.Accept(visitor));
        }
    }
}
