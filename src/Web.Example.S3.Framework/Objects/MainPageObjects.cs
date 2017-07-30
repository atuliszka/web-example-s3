using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Web.Example.S3.Framework.Objects
{
    public class MainPageObjects
    {
        [FindsBy(How = How.XPath, Using = "//li[@id = 'menu-item-401']")]
        public IWebElement CareersDropdown;

        [FindsBy(How = How.XPath, Using = "//li[@id = 'menu-item-444']")]
        public IWebElement VacanciesDropDownItem;
    }
}
