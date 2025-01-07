using OpenQA.Selenium;

namespace SeleniumInterview.Page
{
    public class HomePage : BasePage
    {
        private readonly By _homePageLink = By.LinkText("Home Page Link");
        public readonly By _checkBox = By.Id("checkbox");
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateBackToHome(string url)
        {
            NavigateToUrl(url);
        }

        public void ClickHomePageLink()
        {
            Click(_homePageLink);
        }

        public void ClickCheckBox()
        {
            Click(_checkBox);
        }
    }
}

