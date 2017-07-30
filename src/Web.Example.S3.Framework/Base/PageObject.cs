using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Web.Example.S3.Framework.Base
{
    public abstract class PageObject<T> where T : new()
    {
        protected IWebDriver Driver { get; set; }
        protected T PageElements;
        
        protected PageObject(IWebDriver driver)
        {
            this.Driver = driver;
            this.PageElements = new T();

            PageFactory.InitElements(driver, this.PageElements);
        }
    }
}