using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Web.Example.S3.Framework.Objects
{
    public class VacanciesPageObjects
    {
        [FindsBy(How = How.XPath, Using = "//input[@name = 'jst']")]
        public IWebElement PositionSearchBar;

        [FindsBy(How = How.XPath, Using = "//button[@type = 'submit' and contains(text(), 'Search')]")]
        public IWebElement PositionSearchButton;

        [FindsBy(How = How.XPath, Using = "//td[@data-content = 'Job Title']/a")]
        public IList<IWebElement> AvailablePositions;
    }
}
