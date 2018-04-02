using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTask.Common.POM_Elements.AutomationPractice
{
   public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver _driver)
       {
            driver = _driver;
            PageFactory.InitElements(driver, this);
       }

        [FindsBy(How = How.CssSelector, Using = "div#block_top_menu > ul")]
        public IWebElement HomePageMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#block_top_menu > ul > li:nth-of-type(1) > a")]
        public IWebElement WomenMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#block_top_menu > ul > li:nth-of-type(2) > a")]
        public IWebElement DressesMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#block_top_menu > ul > li:nth-of-type(3) > a")]
        public IWebElement TShirtsMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ul_layered_category_0']/li")]
        public IWebElement WomanCategoryMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.header_user_info a")]
        public IWebElement HomePageSignInButton { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "div.shopping_cart a")]
        public IWebElement CartButton { get; set; }
       
        [FindsBy(How = How.CssSelector, Using = "div#homefeatured > li:nth-of-type(1) > img")]
        public IWebElement ProductMouseOver{ get; set; }

        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'ajax_block_product')]")]
        public IList<IWebElement> Products3 { get; set; }
    }
}
