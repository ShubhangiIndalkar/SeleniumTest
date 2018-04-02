using System;
using System.Collections;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationTask.Common.Utils
{
   public class CommonActions
   {
        private IWebDriver driver;
        
        public CommonActions(IWebDriver _driver)
        {
            this.driver = _driver;
        }
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Enter Text in Textbox
        /// </summary>
        /// <param name="webElement"></param>
        /// <param name="text"></param>
        public void EnterText(IWebElement webElement, string text)
        {
            webElement.SendKeys(text);
        }

        public void Click(IWebElement element)
        {
             element.Click();
        }

       public void SelectDropdownUsingText(IWebElement webElement, string text)
        {
            SelectElement select = new SelectElement(webElement);
            select.SelectByText(text);
        }

        public void SelectDropdownUsingValue(IWebElement webElement, string text)
        {
            SelectElement select = new SelectElement(webElement);
            select.SelectByValue(text);
        }

        public void SelectDropdownUsingIndex(IWebElement webElement, int index)
        {
            SelectElement select = new SelectElement(webElement);
            select.SelectByIndex(index);
        }

        public string GetText(IWebElement webElement)
        {
            return webElement.Text;
        }

        public void ClearText(IWebElement webElement)
        {
            webElement.Clear();
        }

        public void ExplicitWait(IWebElement element, int secondTime)
        {
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(secondTime));
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public bool IsDisplayed(IWebElement webElement)
        {
            return webElement.Displayed;
        }

        public bool IsEnable(IWebElement webElement)
        {
            return webElement.Enabled;
        }

        public bool IsSelected(IWebElement webElement)
        {
            return webElement.Selected;
        }

        public Point PointLocation(IWebElement webElement)
        {
            return webElement.Location;
        }

        public Size GetSize(IWebElement webElement)
        {
            return webElement.Size;
        }

        public string GetAttribute(IWebElement webElement,string attributeName)
        {
            return webElement.GetAttribute(attributeName);
        }

        public string GetTagName(IWebElement webElement)
        {
            return webElement.TagName;
        }

        public void Submit(IWebElement webElement)
        {
            webElement.Submit();
        }

        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }

        public void ForwardPage(IWebElement webElement)
        {
            driver.Navigate().Forward();
        }

        public void BackwardPage(IWebElement webElement)
        {
            driver.Navigate().Back();
        }

        public void AcceptAlertMessage(IWebElement webElement)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        public void DismissAlertMessage(IWebElement webElement)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        public string GetTextFromAlertMessage(IWebElement webElement)
        {
            IAlert alert = driver.SwitchTo().Alert();
            return alert.Text;
        }

        public void SendTextToAlert(IWebElement webElement, string text)
        {

            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys(text);
        }

        public string GetTitle()
        {
            return driver.Title;
        }

        public string GetURL()
       {
           return driver.Url;
       }

        public string PageTitle()
       {
           return driver.Title;
       }

        public void MouseOver(IWebElement webElement)
       {
            var builder = new Actions(driver);
            builder.MoveToElement(webElement).Build().Perform();
        }

       public void SelectRadioButtonById(IWebElement webElement,string value)
       {
         if(webElement.GetAttribute("value").Equals(value))
                webElement.Click();

       }
        public void DisposeDriver()
        {
            driver.Quit();
        }
   }
}
