using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.Utilities.Helper;
using CognizantSoftvision.Maqs.Utilities.Logging;
using NUnit.Framework;
using PageModel;
using System;
using System.IO;

namespace Tests
{
    /// <summary>
    /// SeleniumTest test class with NUnit
    /// </summary>
    [TestFixture]
    public class SeleniumTestsNUnit : BaseSeleniumTest
    {
        /// <summary>
        /// Enter credentials test
        /// </summary>
        [Test]
        public void EnterValidCredentialsTestNUnit()
        {
            this.PerfTimerCollection.StartTimer("Login timer");
            string username = Config.GetGeneralValue("Username");
            string password = Config.GetGeneralValue("Password");

            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();

            this.Log.LogMessage(MessageType.INFORMATION, "Login page opened");

            HomePageModel homepage = page.LoginWithValidCredentials(username, password);
            Assert.IsTrue(homepage.IsPageLoaded());

            this.Log.LogMessage(MessageType.INFORMATION, "Successful login");
            this.PerfTimerCollection.StopTimer("Login timer");
        }
    }
}
