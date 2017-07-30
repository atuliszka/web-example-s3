using OpenQA.Selenium;
using Web.Example.S3.Framework.Base;
using Web.Example.S3.Framework.Constants;
using Web.Example.S3.Framework.Extensions;
using Web.Example.S3.Framework.Objects;

namespace Web.Example.S3.Framework.PageObjects
{
    public class MainPage : PageObject<MainPageObjects>
    {
        public const string Url = PageUrls.MainPage;

        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public void SelectVacanciesDropdownItem()
        {
            this.Driver.Hover(this.PageElements.CareersDropdown);
            this.Driver.TryClick(this.PageElements.VacanciesDropDownItem);
        }
    }
}