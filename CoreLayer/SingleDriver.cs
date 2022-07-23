using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CoreLayer
{
    public class SingleDriver
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
                ConfigureDriver();
            }
            return _driver;
        }

        private static void ConfigureDriver()
        {
            _driver.Manage().Window.FullScreen();
        }
    }
}
