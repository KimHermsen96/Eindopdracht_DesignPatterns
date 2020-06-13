using System;
using System.Collections.Generic;
using System.Text;
using Eindopdracht_DesignPatterns.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests.Nodes
{
    [TestClass]
    public class OrNodeTests
    {

        [TestMethod]
        public void OrNode_hasCorrectOuput_whenInputIs_1()
        {

            Or or = new Or();

            or.CalculateOutput(1);
            Assert.AreEqual(1, or.Value);
        }

        [TestMethod]
        public void OrNode_hasCorrectOuput_whenInputsAre_0()
        {

            Or or = new Or();
            or.CalculateOutput(0);
            or.CalculateOutput(0);

            Assert.AreEqual(0, or.Value);
        }


        [TestMethod]
        public void OrNode_IsValidNode()
        {

            Or or = new Or()
            {
                NumberOfInputNodes = 2
            };

            Assert.AreEqual(true, or.ValidNode());
        }
    }
}
