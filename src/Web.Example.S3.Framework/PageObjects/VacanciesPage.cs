using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Web.Example.S3.Framework.Base;
using Web.Example.S3.Framework.Constants;
using Web.Example.S3.Framework.Extensions;
using Web.Example.S3.Framework.Objects;

namespace Web.Example.S3.Framework.PageObjects
{
    public class VacanciesPage : PageObject<VacanciesPageObjects>
    {
        public const string Url = PageUrls.VacanciesPage;

        public VacanciesPage(IWebDriver driver) : base(driver)
        {
        }

        public void SearchForPosition(string positionTitle)
        {
            this.Driver.TryInput(this.PageElements.PositionSearchBar, positionTitle);
            this.Driver.TryClick(this.PageElements.PositionSearchButton);
        }

        public List<string> GetAvailablePositions()
        {
            return this.PageElements.AvailablePositions.Select(x => x.Text).ToList();
        }
    }
}