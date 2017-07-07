using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using AdvancedUnitTesting.Domain;

namespace AdvancedUnitTesting
{
    [TestClass]
    public class FluentAssertionsEventMonitoringTest
    {
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