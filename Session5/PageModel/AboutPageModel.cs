using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace PageModel
{
    public class AboutPageModel : BaseSeleniumPageModel
    {
        private static string PageUrl = SeleniumConfig.GetWebSiteBase() + "Static/Training1/AboutPage.html";

        /// <summary>
        /// Initializes a new instance of the <see cref="AboutPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public AboutPageModel(ISeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets welcome message
        /// </summary>
        private LazyElement AboutTable
        {
            get { return this.GetLazyElement(By.CssSelector("#AboutTable"), "About table"); }
        }

        /// <summary>
        /// Assert the home page loaded
        /// </summary>
        public void AssertPageLoaded()
        {
            Assert.IsTrue(
                this.IsPageLoaded(),
                "The web page '{0}' is not loaded",
                PageUrl);
        }


        /// <summary>
        /// Open the home page
        /// </summary>
        public void OpenAboutPage()
        {
            this.TestObject.WebDriver.Navigate().GoToUrl(PageUrl);
            this.AssertPageLoaded();
        }

        /// <summary>
        /// Check if the about page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.AboutTable.Displayed;
        }
    }
}