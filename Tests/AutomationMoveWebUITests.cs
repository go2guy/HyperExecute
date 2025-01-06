using SeleniumInterview.Page;

namespace SeleniumInterview.Tests
{
    [TestFixture]
    public class AutomationMoveWebUITests : BaseTest
    {
        private HomePage _homePage;

        [OneTimeSetUp]
        public void Setup()
        {
            _homePage = new HomePage(Driver);
        }

        [Test(Description = "Verify that clicking Home Page Link it takes us to home page"), Order(1)]
        public void TestClickingHomePageLink()
        {
            _homePage.ClickHomePageLink();
            Assert.That(_homePage.GetPageTitle(), Is.EqualTo("COURSES"));   
        }   

        [Test(Description = "Verify checkbox is enabled"), Order(2)]
        public void TestCheckbox()
        {
            _homePage.NavigateBackToHome(Base.Constants.BaseUrl);
            _homePage.ClickCheckBox();
            Assert.That(_homePage.GetCheckBoxValue(_homePage._checkBox));
        }

    }
}
