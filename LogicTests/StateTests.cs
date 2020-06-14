using System;
using System.Collections.Generic;
using System.Text;
using CircuitLogic.controllers.State_pattern;
using CircuitLogic.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests
{
    [TestClass]
    public class StateTests
    {
        [TestMethod]
        public void CreateLoopState()
        {
            var state = new LoopCircuit();
            state.DoAction(new SingleCircuit());
        }

        [TestMethod]
        public void CreateValidState()
        {
            var state = new ValidCircuit();
            state.DoAction(new SingleCircuit());
        }

        [TestMethod]
        public void CreateUnreachableState()
        {
            var state = new UnreachableProbesCircuit();
            state.DoAction(new SingleCircuit());
        }
    }
}
