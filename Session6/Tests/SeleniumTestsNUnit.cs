using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.Utilities.Helper;
using System.Collections.Generic;
using NUnit.Framework;
using PageModel;

namespace Tests
{
    /// <summary>
    /// SeleniumTest test class with NUnit
    /// </summary>
    [TestFixture]
    [Parallelizable]
    public class SeleniumTestsNUnit : BaseSeleniumTest
    {
        /// <summary>
        /// Open page test
        /// </summary>
        [Test]
        public void OpenLoginPageTestNUnit()
        {
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
        }

        /// <summary>
        /// Enter credentials test
        /// </summary>
        [Test]
        public void EnterValidCredentialsTestNUnit()
        {
            string username = Config.GetGeneralValue("Username");
            string password = Config.GetGeneralValue("Password");
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            HomePageModel homepage = page.LoginWithValidCredentials(username, password);
            Assert.IsTrue(homepage.IsPageLoaded());
        }

        /// <summary>
        /// Enter credentials test
        /// </summary>
        [Test]
        public void EnterInvalidCredentialsNUnit()
        {
            string username = "NOT";
            string password = "Valid";
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            Assert.IsTrue(page.LoginWithInvalidCredentials(username, password));
        }

        [Test]
        [TestCaseSource("Data")]
        public void EnterInvalidCredentialeIenumerable(string username, string password)
        {
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            Assert.IsTrue(page.LoginWithInvalidCredentials(username, password));
        }

        public static IEnumerable<object[]> Data
        {
            get 
            {
                yield return new object[] {"Peter", "Parker"};
                yield return new object[] {"Tony", "Stark"};
                yield return new object[] {"Stephen", "Strange"};
                yield return new object[] {"Bruce", "Banner"};
                yield return new object[] {"Steve", "Rogers"};
            }
        }
    }
}
