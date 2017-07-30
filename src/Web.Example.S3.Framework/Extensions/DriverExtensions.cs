using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Web.Example.S3.Framework.Constants;

namespace Web.Example.S3.Framework.Extensions
{
    public static class DriverExtensions
    {
        public static void Hover(this IWebDriver driver, IWebElement webElement)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(Settings.PageLoadTimeout)).Until(ElementIsDisplayed(webElement));
            new Actions(driver).MoveToElement(webElement).Perform();
        }

        public static void TryClick(this IWebDriver driver, IWebElement webElement)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(Settings.PageLoadTimeout)).Until(ElementIsClickable(webElement));

            webElement.Click();
        }

        public static void TryInput(this IWebDriver driver, IWebElement webElement, string input)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(Settings.PageLoadTimeout)).Until(ElementIsClickable(webElement));

            webElement.SendKeys(input);
        }

        private static Func<IWebDriver, IWebElement> ElementIsDisplayed(IWebElement element)
        {
            return driver => element != null && element.Displayed ? element : null;
        }

        private static Func<IWebDriver, IWebElement> ElementIsClickable(IWebElement element)
        {
            return driver => element != null && element.Displayed && element.Enabled ? element : null;
        }
    }
}
