using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AdvancedUnitTesting.Domain;

namespace AdvancedUnitTesting
{
    [TestClass]
    public class FluentAssertionsExampleTest
    {
        [TestMethod]
        public void FluentComplexObject()
        {
            // assign
            var p = Student.Default();

            // act

            // assert properties
            p.Age.Should().Be(30);
            p.Name.Should().StartWith("Tom").And.EndWith("my");
            p.Name.Should().HaveLength(5);

            // assert array
            p.SchoolHistory.Should().HaveCount(4);
            p.SchoolHistory[0].Name.Should().Be("Freising Grundschule");
            p.SchoolHistory[1].Name.Should().Be("Freising Gymnasium");
            p.SchoolHistory[2].Name.Should().Be("Melbourne Hacker Academy");
            p.SchoolHistory[3].Name.Should().Be("Lissabon University for Star Wars Fans");
        }
    }
}