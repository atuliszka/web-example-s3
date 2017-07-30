using NUnit.Framework;
using Web.Example.S3.Framework.Base;
using Web.Example.S3.Framework.Constants;
using Web.Example.S3.Framework.PageObjects;

namespace Web.Example.S3.Tests.Recruitment
{
    [TestFixture(Browsers.Chrome)]
    [TestFixture(Browsers.Firefox)]
    [Parallelizable]
    public class WhenLookingForAJobOpening : Test
    {
        public WhenLookingForAJobOpening(Browsers browser) : base(browser)
        {
        }

        [TestCase("Senior Automation Tests Engineer")]
        public void ThenAtLeastOneGivenPositionIsAvailable(string positionTitle)
        {
            var mainPage = new MainPage(base.WebDriver);
            mainPage.SelectVacanciesDropdownItem();

            var vacanciesPage = new VacanciesPage(base.WebDriver);
            vacanciesPage.SearchForPosition(positionTitle);

            var availablePositions = vacanciesPage.GetAvailablePositions();
            Assert.Multiple(() =>
            {
                Assert.IsNotEmpty(availablePositions);
                Assert.Contains(positionTitle, availablePositions);
            });
        }
    }
}
