using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests;
using Newtonsoft.Json;
using ApprovalTests.Reporters;
using AdvancedUnitTesting.Domain;

namespace AdvancedUnitTesting
{
    [TestClass]
    public class ApprovalTestsExampleTest
    {
        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void ApprovalsComplexObject()
        {
            // assign
            var p = Student.Default();

            // act

            // assert
            Approvals.Verify(p);
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void ApprovalsComplexObjectJson()
        {
            // assign
            var p = Student.Default();

            // act

            // assert
            Approvals.VerifyJson(JsonConvert.SerializeObject(p));
        }

        [TestMethod]
        [UseReporter(typeof(DiffReporter))]
        public void ApprovalsArray()
        {
            // assign
            var p = Student.Default();

            // act

            // assert... old way
            string pSerialized = JsonConvert.SerializeObject(p, Formatting.Indented);
            Approvals.VerifyAll(p.SchoolHistory.Select(c=>c.Name), "Schlool");
        }
    }
}