using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.BaseSeleniumTest.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for the Automation page
    /// </summary>
    public class HomePageModel : BaseSeleniumPageModel
    {
        private static string PageUrl = SeleniumConfig.GetWebSiteBase() + "Static/Training1/HomePage.html";
        /// <summary>
        /// Initializes a new instance of the <see cref="HomePageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public HomePageModel(ISeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets welcome message
        /// </summary>
        private LazyElement WelcomeMessage
        {
            get { return this.GetLazyElement(By.CssSelector("#WelcomeMessage"), "Welcome message"); }
        }

        /// <summary>
        /// Gets about button
        /// </summary>
        private LazyElement AboutButton
        {
            get { return this.GetLazyElement(By.CssSelector("#About"), "About button"); }
        }

        /// <summary>
        /// Click the About button
        /// </summary>
        public AboutPageModel ClickAboutButton()
        {
            this.AboutButton.Click();

            return new AboutPageModel(this.TestObject);
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
        public void OpenHomePage()
        {
            this.TestObject.WebDriver.Navigate().GoToUrl(PageUrl);
            this.AssertPageLoaded();
        }

        /// <summary>
        /// Check if the home page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.WelcomeMessage.Displayed;
        }
    }
}

