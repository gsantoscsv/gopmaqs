using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.BaseSeleniumTest.Extensions;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for the Automation page
    /// </summary>
    public class AsyncPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public AsyncPageModel(ISeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets async content
        /// </summary>
        private LazyElement AsyncContent
        {
            get { return this.GetLazyElement(By.CssSelector("#AsyncContent"), "Async content"); }
        }

        /// <summary>
        /// Check if the how it works page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.AsyncContent.Displayed;
        }
    }
}