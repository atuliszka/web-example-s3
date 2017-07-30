using NUnit.Framework;
using OpenQA.Selenium;
using Web.Example.S3.Framework.Constants;
using Web.Example.S3.Framework.Factories;

namespace Web.Example.S3.Framework.Base
{
    public abstract class Test
    {
        public IWebDriver WebDriver;

        protected Test(Browsers browser)
        {
            var driverFactory = new WebDriverFactory();
            driverFactory.Setup(browser);

            this.WebDriver = driverFactory.WebDriver;
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            this.WebDriver.Navigate().GoToUrl(GlobalConfiguration.BaseUrl);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            this.WebDriver.Quit();
        }
    }
}