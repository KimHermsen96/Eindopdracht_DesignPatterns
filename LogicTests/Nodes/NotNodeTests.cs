using CircuitLogic.controllers;
using CircuitLogic.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests.Nodes
{
    [TestClass]
    public class NotNodeTests
    {


        [TestMethod]
        public void NotNode_hasCorrectOuput_whenInputIs_0()
        {

            Not not = new Not()
            {
                NumberOfInputNodes = 1
            };

            not.CalculateOutput(0);
            Assert.AreEqual(1, not.Value);
        }


        [TestMethod]
        public void NotNode_hasCorrectOuput_whenInputIs_1()
        {

            Not not = new Not();

            not.CalculateOutput(1);
            Assert.AreEqual(0, not.Value);
        }


        [TestMethod]
        public void NotNode_IsInValidNode()
        {

            Not not = new Not()
            {
                NumberOfInputNodes = 2
            };
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(false, not.Accept(visitor));
        }

        [TestMethod]
        public void NotNode_IsValidNode()
        {

            Not not = new Not()
            {
                NumberOfInputNodes = 1
            };
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(true, not.Accept(visitor));
        }
    }
}
