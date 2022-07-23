using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CoreLayer
{
    public static class DriverExtensions
    {
        public static IWebElement WaitForElementToAppear(this IWebDriver driver, By locator)
            => new WebDriverWait(SingleDriver.GetDriver(), TimeSpan.FromSeconds(10))
                .Until(driver => driver.FindElement(locator));
    }
}
