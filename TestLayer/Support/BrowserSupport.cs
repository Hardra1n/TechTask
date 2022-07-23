using CoreLayer;

namespace TestLayer.Support
{
    [Binding]
    internal class BrowserSupport
    {
        [AfterScenario("browser")]
        public void CloseBrowser()
        {
            SingleDriver.Close();
        }
    }
}
