using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace SeleniumInterview.Page
{
    public class BasePage
    {
        private readonly IWebDriver _driver;
        protected WebDriverWait Wait;
        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        protected void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        protected void WaitUntilElementClickable(By by)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected IWebElement GetElement(By by)
        {
            WaitUntilElementClickable(by);
            return _driver.FindElement(by);
        }

        protected void Click(By by)
        {
            WaitUntilElementClickable(by);
            
            _driver.FindElement(by).Click();
        }

        protected void SendKeys(By by, string text)
        {
            WaitUntilElementClickable(by);
            _driver.FindElement(by).SendKeys(text);
        }

        public string GetPageTitle()
        {
            string PageTitle = _driver.Title;
            return PageTitle;
        }

        public bool GetCheckBoxValue(By by)
        {
            WaitUntilElementClickable(by);
            return _driver.FindElement(by).Enabled;
        }
    }
}
