using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;

namespace BP_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIdealBloodPressure()
        {
            // Test for ideal blood pressure
            var bp = new BloodPressure { Systolic = 110, Diastolic = 70 };
            Assert.AreEqual(BPCategory.Ideal, bp.Category, "Blood pressure should be categorized as Ideal");
        }

        [TestMethod]
        public void TestHighBloodPressure()
        {
            // Test for high blood pressure
            var bp = new BloodPressure { Systolic = 160, Diastolic = 95 };
            Assert.AreEqual(BPCategory.High, bp.Category, "Blood pressure should be categorized as High");
        }
    }
}
