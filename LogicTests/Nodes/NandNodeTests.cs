using Eindopdracht_DesignPatterns.models.Nodes;
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

            Assert.AreEqual(true, nand.ValidNode());
        }


        [TestMethod]
        public void NandNode_IsUnvalidNode()
        {

            Nand nand = new Nand()
            {
                NumberOfInputNodes = 1
            };

            Assert.AreEqual(false, nand.ValidNode());
        }
    }
}
