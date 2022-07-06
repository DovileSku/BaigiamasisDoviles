
using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FinalWorkDovile
{
    public class Driver
    {
        public static IWebDriver driver;

        public static void setDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        public static void open(string url)
        {
            driver.Url = url;
        }

        public static void takeScreenshot()
        {
            string screenshotsPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{screenshotsPath}\\src-{Guid.NewGuid()}.png";

            Directory.CreateDirectory(screenshotsPath);
            Screenshot screenshot = ((ITakesScreenshot)Driver.getDriver()).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }

        public static void closeDriver()
        {
            driver.Quit();
        }
    }
}
