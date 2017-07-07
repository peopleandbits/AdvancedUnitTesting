using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvancedUnitTesting.Domain;

namespace AdvancedUnitTesting
{
    [TestClass]
    public class MSTestExampleTest
    {
        [TestMethod]
        public void MSTestComplexObject()
        {
            // assign
            var p = Student.Default();

            // act

            // assert properties
            Assert.AreEqual(30, p.Age);
            Assert.IsTrue(p.Name.StartsWith("Tom") && p.Name.EndsWith("my"));
            Assert.AreEqual(5, p.Name.Length);

            // assert array
            Assert.AreEqual(4, p.SchoolHistory.Length);
            Assert.AreEqual("Freising Grundschule", p.SchoolHistory[0].Name);
            Assert.AreEqual("Freising Gymnasium", p.SchoolHistory[1].Name);
            Assert.AreEqual("Melbourne Hacker Academy", p.SchoolHistory[2].Name);
            Assert.AreEqual("Lissabon University for Star Wars Fans", p.SchoolHistory[3].Name);
        }
    }
}