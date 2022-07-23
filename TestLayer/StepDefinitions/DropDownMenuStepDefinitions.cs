using CoreLayer.Pages;
using NUnit.Framework;

namespace TestLayer.StepDefinitions
{
    [Binding]
    public class DropDownMenuStepDefinitions
    {
        private BasePage _page;

        object result;

        [Given(@"Browser is on the DDM page")]
        public void BrowserIsOnTheDDMPage()
        {
            _page = new DropDownMenuPage();
        }

        [When(@"Number of options in DDM is calculated")]
        public void NumberOfOptionsInDDMIsCalculated()
        {
            var page = (DropDownMenuPage)_page;
            result = page.GetNumberOfOptions();
        }

        [Then(@"Result equals to '(.*)'")]
        public void ResultEqualsTo(int number)
        {
            Assert.AreEqual(number, result);
        }
    }
}
