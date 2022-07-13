using CognizantSoftvision.Maqs.BaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// BasicNUnitTest test class with NUnit
    /// </summary>
    [TestClass]
    public class BasicNUnitTests : BaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [TestMethod]
        public void SampleTest()
        {
            this.TestObject.Log.LogMessage("Start Test");
            Assert.IsTrue(true, "True is Not True");
        }
    }
}