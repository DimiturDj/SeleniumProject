using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace InstagramTests
{
    [TestFixture]
    public class LoginPageTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void VerifyLoginButtonIsPresent()
        {
            driver.Navigate().GoToUrl("https://www.instagram.com");
            System.Threading.Thread.Sleep(5000);
            var loginButton = driver.FindElement(By.XPath("//button[contains(text(),'Log in')]"));
            Assert.IsTrue(loginButton.Displayed, "Log In button should be displayed on the page.");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
