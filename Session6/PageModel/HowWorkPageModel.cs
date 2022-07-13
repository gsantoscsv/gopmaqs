using CognizantSoftvision.Maqs.BaseSeleniumTest;
using CognizantSoftvision.Maqs.BaseSeleniumTest.Extensions;
using OpenQA.Selenium;

namespace PageModel
{
    /// <summary>
    /// Page object for the Automation page
    /// </summary>
    public class HowWorkPageModel : BaseSeleniumPageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HowWorkPageModel" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public HowWorkPageModel(ISeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets works well message
        /// </summary>
        private LazyElement WorksWellMessage
        {
            get { return this.GetLazyElement(By.CssSelector("#HowWorks"), "Works well message"); }
        }

        /// <summary>
        /// Check if the how it works page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.WorksWellMessage.Displayed;
        }
    }
}