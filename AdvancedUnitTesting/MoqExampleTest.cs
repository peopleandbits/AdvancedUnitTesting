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
        public void WhenCarIsGivenAnIdealMockMotor_ThenDriveReturnsTrue()
        {
            // assign
            var motor = new Mock<IMotor>();
            motor.Setup(c => c.Start()).Returns(true);
            motor.Setup(c => c.Stop()).Returns(true);
            var car = new Car(motor.Object);

            // act
            bool result = car.Drive();

            // assert
            result.Should().BeTrue();
        }
    }
}