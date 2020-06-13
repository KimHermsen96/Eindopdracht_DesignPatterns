using System;
using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.controllers.State_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests
{
    [TestClass]
    public class ValidatorTests
    {
        private CachedCircuitValidator ProxyCircuitValidator { get; set; }
        public ValidatorTests()
        {
            ProxyCircuitValidator =  new CachedCircuitValidator();
        }
        [TestMethod]
        public void File1_isValidCircuit()
        {
            CircuitMaker circuitMaker = new CircuitMaker("Circuit1_FullAdder.txt");
            var singlecir = circuitMaker.MakeCircuit();

            CircuitValidator validator = new CircuitValidator(singlecir);
            ProxyCircuitValidator.Circuit = singlecir;
            ProxyCircuitValidator.CircuitValidator = validator;
            ProxyCircuitValidator.SetState();

            Assert.IsInstanceOfType(singlecir.State, typeof(ValidCircuit) );
        }

        [TestMethod]
        public void File4_isInfiniteLoop()
        {
            CircuitMaker circuitMaker = new CircuitMaker("Circuit4_InfiniteLoop.txt");
            var singlecir = circuitMaker.MakeCircuit();

            CircuitValidator validator = new CircuitValidator(singlecir);
            ProxyCircuitValidator.Circuit = singlecir;
            ProxyCircuitValidator.CircuitValidator = validator;
            ProxyCircuitValidator.SetState();

            Assert.IsInstanceOfType(singlecir.State, typeof(Loop));
        }
        [TestMethod]
        public void File5_IsNotConnected()
        {
            CircuitMaker circuitMaker = new CircuitMaker("Circuit5_NotConnected.txt");
            var singlecir = circuitMaker.MakeCircuit();

            CircuitValidator validator = new CircuitValidator(singlecir);
            ProxyCircuitValidator.Circuit = singlecir;
            ProxyCircuitValidator.CircuitValidator = validator;
            ProxyCircuitValidator.SetState();

            Assert.IsInstanceOfType(singlecir.State, typeof(UnreachableProbes));
        }
    }
}
