using System;
using System.Collections.Generic;
using System.Text;
using CircuitLogic.controllers.Adapter_pattern;
using CircuitLogic.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTests
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void JsonAdapter_ReturnsListOfCircuitFiles()
        {
            var JsonAdapter = new JsonToListAdapter();
            Assert.IsInstanceOfType(JsonAdapter.ToList(), typeof(List<CircuitFile>));
        }

        [TestMethod]
        public void XmlAdapter_ReturnsListOfCircuitFiles()
        {
            var xmlAdapter = new XmlToListAdapter();
            Assert.IsInstanceOfType(xmlAdapter.ToList(), typeof(List<CircuitFile>));
        }
    }
}
