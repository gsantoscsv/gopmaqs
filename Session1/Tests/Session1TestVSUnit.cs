using CognizantSoftvision.Maqs.BaseTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    /// BaseGenericTestVSUnit test class with VS unit
    /// </summary>
    [TestClass]
    public class Session1TestVSUnit : BaseTest
    {
        /// <summary>
        /// Sample test
        /// </summary>
        [TestMethod]
        public void Session1Test()
        {
            this.TestObject.Log.LogMessage("My Test");
            Assert.IsTrue(true, "True is Not True");
        }
    }
}