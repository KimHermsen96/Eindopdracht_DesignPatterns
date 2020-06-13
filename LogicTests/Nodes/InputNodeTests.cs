using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.models.Nodes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests.Nodes
{
    [TestClass]
    public class InputNodeTests
    {

        [TestMethod] public void InputValue_DoesNotChange()
        {
            Input input = new Input()
            {
                Value = 1,
            };
            input.CalculateOutput(1);
            Assert.AreEqual(1, input.Value);
        }

        [TestMethod]
        public void InputValue_IsValid()
        {
            Input input = new Input()
            {
                Value = 1
            };
            input.CalculateOutput(0);
            ValidNodeVisitor visitor = new ValidNodeVisitor();
            Assert.AreEqual(true, input.Accept(visitor));
        }

    }
}
