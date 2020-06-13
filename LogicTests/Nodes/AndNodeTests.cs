using Eindopdracht_DesignPatterns.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests.Nodes
{
    [TestClass]
    public class AndNodeTests
    {
        [TestMethod]
        public void AndNode_hasCorrectOutput_WhenInputIs_0()
        {

            And and = new And();
            and.CalculateOutput(0);
            Assert.AreEqual(0, and.Value);
        }

        [TestMethod]
        public void AndNode_hasCorrectOutput__WhenInputsAre_1()
        {

            And and = new And();
            and.NumberOfInputNodes = 2;
            and.CalculateOutput(1);
            and.CalculateOutput(1);
            Assert.AreEqual(1, and.Value);
        }

        [TestMethod]
        public void AndNode_IsValidNode()
        {

            And and = new And();
            and.NumberOfInputNodes = 3;

            Assert.AreEqual( true, and.ValidNode());
        }
    }
}
