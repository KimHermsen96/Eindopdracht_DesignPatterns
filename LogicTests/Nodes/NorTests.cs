using System;
using System.Collections.Generic;
using System.Text;
using CircuitLogic.controllers;
using CircuitLogic.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests.Nodes
{
    [TestClass]
    public class NorTests
    {

        [TestMethod]
        public void NorNode_hasCorrectOuput_whenInputIs_1()
        {

            Nor nor = new Nor()
            {
                NumberOfInputNodes = 2
                
            };

            nor.CalculateOutput(1);
            Assert.AreEqual(0, nor.Value);
        }

        [TestMethod]
        public void NorNode_hasCorrectOuput_whenInputsAre_0And1()
        {

            Nor nor = new Nor()
            {
                NumberOfInputNodes = 2

            };

            nor.CalculateOutput(0);
            nor.CalculateOutput(1);
            Assert.AreEqual(0, nor.Value);
        }

        [TestMethod]
        public void NorNode_hasCorrectOuput_whenInputsAre_0()
        {

            Nor nor = new Nor()
            {
                NumberOfInputNodes = 2

            };

            nor.CalculateOutput(0);
            nor.CalculateOutput(0);
            Assert.AreEqual(1, nor.Value);
        }

        [TestMethod]
        public void NorNode_IsValidNode()
        {

            Nor nor = new Nor()
            {
                NumberOfInputNodes = 2
            };
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(true, nor.Accept(visitor));
        }
    }
}
