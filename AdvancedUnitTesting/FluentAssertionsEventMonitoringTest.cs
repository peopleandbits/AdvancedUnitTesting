using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AdvancedUnitTesting.Domain;

namespace AdvancedUnitTesting
{
    [TestClass]
    public class FluentAssertionsEventMonitoringTest
    {
        [TestMethod]
        public void WhenMyMethodCalled_ThenThanksIsReturned()
        {
            var empty = new MagicBox();
            empty.MyMethod(1).Should().Be("Thanks");
        }

        [TestMethod]
        public void WhenMyMethodParamIs3_ThenEventIsRaisedAndNullReturned()
        {
            var empty = new MagicBox();
            empty.MonitorEvents();
            empty.MyMethod(3).Should().BeNull();
            empty.ShouldRaise("ErgebnisseReady");
        }
    }
}