using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FluentAssertions;
using AdvancedUnitTesting.Domain;

namespace AdvancedUnitTesting
{
    [TestClass]
    public class MoqExampleTest
    {
        [TestMethod]
        public void MoqNotImplementedMethod()
        {
            // assign
            var p = Student.Default();
            var mock = new Mock<IDiplomaPrinter>();
            mock.Setup(c => c.PrintDiploma(p)).Returns("From mock diploma writer...");
            var school = new School("Freising Gymnasium", mock.Object);

            // act
            string diploma = school.GraduateStudent(p);

            // assert properties
            diploma.Should().Be("From mock diploma writer...");
        }
    }
}