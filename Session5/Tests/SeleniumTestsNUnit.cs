using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.Utilities.Helper;
using NUnit.Framework;
using PageModel;

namespace Tests
{
    /// <summary>
    /// SeleniumTest test class with NUnit
    /// </summary>
    [TestFixture]
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

        /// <summary>
        /// Open page test
        /// </summary>
        [Test]
        public void VerifyHomePageTestNUnit()
        {
            HomePageModel page = new HomePageModel(this.TestObject);
            page.OpenHomePage();
            Assert.IsTrue(page.IsPageLoaded());
        }

        /// <summary>
        /// Open page test
        /// </summary>
        [Test]
        public void ClickAboutButtonTestNUnit()
        {
            HomePageModel page = new HomePageModel(this.TestObject);
            page.OpenHomePage();
            page.ClickAboutButton();
        }

        /// <summary>
        /// Open page test
        /// </summary>
        [Test]
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
