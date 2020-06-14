using CircuitLogic.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CircuitLogic.controllers;
using CircuitLogic.models.Nodes;

namespace LogicTests
{
    [TestClass]
    public class CircuitTests
    {

        [TestMethod]
        public void CreateCircuitFile()
        {

            var circuit = new CircuitFile()
            {
                Name = "newFile",
                Location = "newFile.txt"
            };

            var name = circuit.Name;
            var location = circuit.Location;
            Assert.AreEqual("newFile", name);
            Assert.AreEqual("newFile.txt", location);
        }


        [TestMethod]
        public void CreateSingleCircuit()
        {
            var singleCircuit = new SingleCircuit();
            var validNodeVisitor = new ValidNodeVisitor();


            Assert.AreEqual(true, singleCircuit.Accept(validNodeVisitor));


        }
        [TestMethod]
        public void SetNodesTo_FinishesIsFalse_WhenCircuitIsCleared()
        {
            SingleCircuit circuit = new SingleCircuit();
            var and = new And()
            {
                Finished = true
            };

            circuit.AllNodes.Add("and", and);
            circuit.Clear();

            Assert.AreEqual( false, and.Finished);
        }
    }
}
