using CoreLayer;

namespace TestLayer.Support
{
    internal class BrowserSupport
    {
        [AfterFeature("browser")]
        public void CloseBrowser()
        {
            SingleDriver.GetDriver().Close();
        }
    }
}
