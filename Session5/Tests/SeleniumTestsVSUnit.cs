using CognizantSoftvision.Maqs.BaseSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CognizantSoftvision.Maqs.Utilities.Helper;
using PageModel;

namespace Tests
{
    /// <summary>
    /// SeleniumTest test class with VS unit
    /// </summary>
    [TestClass]
    public class SeleniumTestsVSUnit : BaseSeleniumTest
    {
        /// <summary>
        /// Open page test
        /// </summary>
        [TestMethod]
        public void OpenLoginPageTest()
        {
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
        }

        /// <summary>
        /// Enter credentials test
        /// </summary>
        [TestMethod]
        public void EnterValidCredentialsTest()
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
        [TestMethod]
        public void EnterInvalidCredentials()
        {
            string username = "NOT";
            string password = "Valid";
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            Assert.IsTrue(page.LoginWithInvalidCredentials(username, password));
        }

        /// <summary>
        /// Open page test
        /// </summary>
        [TestMethod]
        public void VerifyHomePageTestNUnit()
        {
            HomePageModel page = new HomePageModel(this.TestObject);
            page.OpenHomePage();
            Assert.IsTrue(page.IsPageLoaded());
        }

        /// <summary>
        /// Open page test
        /// </summary>
        [TestMethod]
        public void ClickAboutButtonTestNUnit()
        {
            HomePageModel page = new HomePageModel(this.TestObject);
            page.OpenHomePage();
            page.ClickAboutButton();
        }

        /// <summary>
        /// Open page test
        /// </summary>
        [TestMethod]
        public void VerifyAboutPageTestNUnit()
        {
            HomePageModel page = new HomePageModel(this.TestObject);
            page.OpenHomePage();
            page.ClickAboutButton();
            AboutPageModel aboutpage = new AboutPageModel(this.TestObject);
            Assert.IsTrue(aboutpage.IsPageLoaded());
        }
    }
}
