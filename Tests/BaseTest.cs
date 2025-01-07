using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumInterview.Base;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace SeleniumInterview.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver? Driver;
        private readonly string _baseUrl = Constants.BaseUrl;

        [OneTimeSetUp]
        public void SetUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);   
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(_baseUrl);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
