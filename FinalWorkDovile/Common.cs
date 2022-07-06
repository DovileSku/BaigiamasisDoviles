using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace FinalWorkDovile
{
    public class Common
    {
            public static IWebElement getElement(string locator)
            {
                return Driver.getDriver().FindElement(By.XPath(locator));
            }

            public static void clickElement(string locator)
            {
                getElement(locator).Click();
            }

        internal static void switchToNewWindowFromParentWindowByHandle(string parentWindowHandle)
        {
            List<string> handles = getCurrentWindowHandles();
            foreach (string handle in handles)
            {
                if (handle != parentWindowHandle)
                {
                    Common.switchToWindowByHandle(handle);
                }
            }
        }

        internal static string getCurrentWindowHandle()
        {
            return Driver.getDriver().CurrentWindowHandle;
        }

        public static void switchToWindowByHandle(string handle)
        {
            Driver.getDriver().SwitchTo().Window(handle);
        }

        public static List<string> getCurrentWindowHandles()
        {
            return Driver.getDriver().WindowHandles.ToList();
        }

        public static void sendKeysToElement(string locator, string keys)
        {
             getElement(locator).SendKeys(keys);
        }

        public static void waitForElementToBeClickable(string locator)
        {
             WebDriverWait wait = new WebDriverWait(Driver.getDriver(), TimeSpan.FromSeconds(10));
             wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locator)));
        }
        
        public static string getElementText(string locator)
        {
             return getElement(locator).Text;
        }

        public static void login()
        {
             string expectedEmail = "dovile.skujiene@gmail.com";
             string expectedPassword = "Skujiene";

             InvalidLoginDataPage.enterEmail(expectedEmail);
             InvalidLoginDataPage.enterPassword(expectedPassword);
             InvalidLoginDataPage.ClickPrisijungtiButton();
        }

        public static void alertAccept()
        {
             Driver.getDriver().SwitchTo().Alert().Accept();
        }

        }
}
