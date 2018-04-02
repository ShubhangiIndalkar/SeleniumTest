using AutomationTask.Common.POM_Elements.AutomationPractice;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;

namespace AutomationTask.Common.Utils
{
    public class WebPortal
    {
        private string _browser;
        public EventFiringWebDriver _Driver;
        public HomePage _homePage;
        public CommonActions _CommonActions;
        public ContactUsPage _ContactUsPage;
        public SignInPage _SignInPage;

        public WebPortal(string browser)
        {
            _browser = browser;
        }

        public void Create()
        {
            if (_Driver == null)
            {
                _Driver = new WebDriverFactory().CreateDriver(_browser);
                _homePage=new HomePage(_Driver);
                _CommonActions=new CommonActions(_Driver);
                _ContactUsPage=new ContactUsPage(_Driver);
                _SignInPage=new SignInPage(_Driver);
            }
        }

        public IWebDriver Driver
        {
            get
            {
                Create();
                return _Driver;
            }
        }

        public HomePage HomePage
        {
            get
            {
                Create();
                return _homePage;
            }
        }

        public CommonActions CommonActions
        {
            get
            {
                Create();
                return _CommonActions;
            }
        }

        public ContactUsPage ContactUsPage
        {
            get
            {
                Create();
                return _ContactUsPage;
            }
        }

        public SignInPage SignInPage
        {
            get
            {
                Create();
                return _SignInPage;
            }
        }
    }
}
