using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.Events;

namespace AutomationTask.Common.Utils
{
    public class WebDriverFactory
    {
        public EventFiringWebDriver CreateDriver(string browser)
        {
            if(browser==null)
                throw new ArgumentNullException("Browser must not be null");

            switch (browser.ToUpper())
            {
                case "IE":
                    return new EventFiringWebDriver(new InternetExplorerDriver());
                case "CHROME":
                    return new EventFiringWebDriver(new ChromeDriver());
                case "FIREFOX":
                    return new EventFiringWebDriver(new FirefoxDriver());
            }

            throw new NotSupportedException(browser + "  browser is not supported");
        }
    }
}
