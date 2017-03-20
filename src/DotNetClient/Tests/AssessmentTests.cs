using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Wonde;
using Wonde.EndPoints;
using Wonde.EndPoints.Assessments;

namespace Tests
{
    [TestClass]
    public class AssessmentTests
    {
        private Schools school;

        [TestInitialize]
        public void initialize()
        {
            var client = new Client(System.Configuration.ConfigurationManager.AppSettings["API_TOKEN"]);
            school = client.school(System.Configuration.ConfigurationManager.AppSettings["SCHOOL_ID"]);
            client = null;
        }

        [TestCleanup]
        public void cleanup()
        {
            school = null;
        }

        [TestMethod]
        public void test_templates()
        {
            var result = school.assessment.Templates.all();
            Assert.IsNotNull(result);

            foreach (Dictionary<string, object> row in result)
            {
                Assert.IsNotNull(row);
                Assert.IsInstanceOfType(row, typeof(Dictionary<string, object>));
                Assert.IsTrue(row.Count > 0);
            }

            Assert.IsTrue(result.ArrayData.Count > 10, "Assessment templates count fails.");
        }

        [TestMethod]
        public void test_aspects()
        {
            var result = school.assessment.Aspects.all();
            Assert.IsNotNull(result);

            foreach (Dictionary<string, object> row in result)
            {
                Assert.IsNotNull(row);
                Assert.IsInstanceOfType(row, typeof(Dictionary<string, object>));
                Assert.IsTrue(row.Count > 0);
            }

            Assert.IsTrue(result.ArrayData.Count > 10, "Assessment aspects count fails.");
        }

        [TestMethod]
        public void test_results()
        {
            var result = school.assessment.Results.all();
            Assert.IsNotNull(result);

            foreach (Dictionary<string, object> row in result)
            {
                Assert.IsNotNull(row);
                Assert.IsInstanceOfType(row, typeof(Dictionary<string, object>));
                Assert.IsTrue(row.Count > 0);
            }

            Assert.IsTrue(result.ArrayData.Count > 10, "Assessment results count fails.");
        }

        [TestMethod]
        public void test_resultsets()
        {
            var result = school.assessment.ResultSets.all();
            Assert.IsNotNull(result);

            foreach (Dictionary<string, object> row in result)
            {
                Assert.IsNotNull(row);
                Assert.IsInstanceOfType(row, typeof(Dictionary<string, object>));
                Assert.IsTrue(row.Count > 0);
            }

            Assert.IsTrue(result.ArrayData.Count > 10, "Assessment resultsets count fails.");
        }

        [TestMethod]
        public void test_marksheets()
        {
            var result = school.assessment.MarkSheets.all();
            Assert.IsNotNull(result);

            foreach (Dictionary<string, object> row in result)
            {
                Assert.IsNotNull(row);
                Assert.IsInstanceOfType(row, typeof(Dictionary<string, object>));
                Assert.IsTrue(row.Count > 0);
            }

            Assert.IsTrue(result.ArrayData.Count > 10, "Assessment marksheets count fails.");
        }
    }
}
