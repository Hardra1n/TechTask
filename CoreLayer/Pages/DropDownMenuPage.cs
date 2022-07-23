using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CoreLayer.Pages
{
    public class DropDownMenuPage : BasePage
    {
        private const string URL 
            = "https://www.globalsqa.com/demo-site/select-dropdown-menu/";

        public DropDownMenuPage() : base(URL) { }

        private SelectElement DropDownMenu
            => new(Driver.WaitForElementToAppear(
                By.XPath("//select")));

        public int GetNumberOfOptions()
            => DropDownMenu.Options.Count;
    }
}
