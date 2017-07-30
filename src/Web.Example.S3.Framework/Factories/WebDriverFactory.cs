using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Web.Example.S3.Framework.Constants;
using Web.Example.S3.Framework.Exceptions;

namespace Web.Example.S3.Framework.Factories
{
    public class WebDriverFactory
    {
        public IWebDriver WebDriver { get; set; }

        public void Setup(Browsers browser)
        {
            this.WebDriver = SetupDriver(browser);

            this.WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Settings.PageLoadTimeout);
            this.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Settings.PageElementTimeout);
            this.WebDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(Settings.AsynchronousJavaScriptTimeout);

            this.WebDriver.Manage().Window.Maximize();
        }

        public void Quit()
        {
            this.WebDriver.Quit();
        }

        private static IWebDriver SetupDriver(Browsers browser)
        {
            switch (browser)
            {
                case Browsers.Chrome:
                {
                    var options = new ChromeOptions();

                    options.AddArgument("--start-maximized");
                    options.AddArgument("--ignore-certificate-errors");
                    options.AddArgument("--disable-popup-blocking");
                    options.AddArgument("--incognito");

                    options.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);

                    return new ChromeDriver(options);
                }

                case Browsers.Firefox:
                {
                    var profile = new FirefoxProfile
                    {
                        AcceptUntrustedCertificates = true,
                        DeleteAfterUse = true,
                    };

                    return new FirefoxDriver(profile);
                }
                    
                case Browsers.Edge:
                    return new EdgeDriver();
                case Browsers.InternetExplorer:
                    return new InternetExplorerDriver();

                default:
                    throw new BrowserNotSupportedException(nameof(browser));
            }
        }
    }
}
