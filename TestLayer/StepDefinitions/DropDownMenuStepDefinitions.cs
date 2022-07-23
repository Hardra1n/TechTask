using System;
using TechTalk.SpecFlow;

namespace TestLayer.StepDefinitions
{
    [Binding]
    public class DropDownMenuStepDefinitions
    {
        [Given(@"Browser is on the DDM page")]
        public void BrowserIsOnTheDDMPage()
        {
            throw new PendingStepException();
        }

        [When(@"Number of options in DDM is calculated")]
        public void NumberOfOptionsInDDMIsCalculated()
        {
            throw new PendingStepException();
        }

        [Then(@"Result equals to '(.*)'")]
        public void ResultEqualsTo(int number)
        {
            throw new PendingStepException();
        }
    }
}
