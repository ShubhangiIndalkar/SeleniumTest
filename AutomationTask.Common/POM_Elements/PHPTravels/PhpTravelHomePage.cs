using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTask.Common.POM_Elements.PHPTravels
{
   public class PhpTravelHomePage
    {
        private IWebDriver driver;
        public PhpTravelHomePage(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "nav navbar-nav navbar-left go-right")]
        public IWebElement HomePageMenu { get; set; }
    }
}
