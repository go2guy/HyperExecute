using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);   
            //Driver = new ChromeDriver();
            //Driver.Manage().Window.Maximize();
            //Driver.Navigate().GoToUrl(_baseUrl);

            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            var lt_username = "herb.scruggs";
            var lt_access_key = "dZzoXAahYZcEgODLx6JOnI9qAiNiksiiRNV1Jkxe05qGhl5S8s";
            var gridURL = "@hub.lambdatest.com/wd/hub";
            
            Driver = new RemoteWebDriver(new Uri("https://" + lt_username + ":" + lt_access_key + gridURL),
                            (ICapabilities)options, TimeSpan.FromSeconds(600));
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
