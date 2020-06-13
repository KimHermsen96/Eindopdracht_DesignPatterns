using CircuitLogic.controllers;
using CircuitLogic.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests.Nodes
{
    [TestClass]
    public class NandNodeTests
    {
        [TestMethod]
        public void NandNode_hasCorrectOuput_whenInputsAre_1()
        {

            Nand nand = new Nand()
            {
                NumberOfInputNodes = 2
            };

           nand.CalculateOutput(1);
           nand.CalculateOutput(1);

            Assert.AreEqual(0, nand.Value);
        }

        [TestMethod]
        public void NandNode_hasCorrectOuput_whenInputIs_0()
        {

            Nand nand = new Nand()
            {
                NumberOfInputNodes = 2
            };

            nand.CalculateOutput(0);

            Assert.AreEqual(1, nand.Value);
        }


        [TestMethod]
        public void NandNode_IsValidNode()
        {

            Nand nand = new Nand()
            {
                NumberOfInputNodes = 2
            };
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(true, nand.Accept(visitor));
        }


        [TestMethod]
        public void NandNode_IsUnvalidNode()
        {

            Nand nand = new Nand()
            {
                NumberOfInputNodes = 1
            };
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(false, nand.Accept(visitor));
        }
    }
}
