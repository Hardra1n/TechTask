﻿using OpenQA.Selenium;

namespace CoreLayer.Pages
{
    public abstract class BasePage
    {
        public BasePage(string url)
        {
            Driver = SingleDriver.GetDriver();
            Driver.Navigate().GoToUrl(url);
        }

        protected IWebDriver Driver { get; set; }
    }
}
