using CognizantSoftvision.Maqs.BaseSeleniumTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CognizantSoftvision.Maqs.Utilities.Helper;
using System.Collections.Generic;
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
        /// Do a class setup that writes to the console
        /// </summary>
        [ClassInitialize]
        public static void TestSetup(TestContext context)
        {
            // Write to the console
            System.Console.WriteLine("Class Setup");
        }

        /// <summary>
        /// Do a method teardown function that writes to the console
        /// </summary>
        [ClassCleanup]
        public static void TestCleanup()
        {
            // Write to the console
            System.Console.WriteLine("Function Teardown");
        }

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
        /// Data driven test
        /// </summary>
        [DataTestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Property)]
        public void EnterInvalidCredentialeIenumerable(string username, string password)
        {
            LoginPageModel page = new LoginPageModel(this.TestObject);
            page.OpenLoginPage();
            Assert.IsTrue(page.LoginWithInvalidCredentials(username, password));
        }

        /// <summary>
        /// Five invalid logins for data driven test
        /// </summary>
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
