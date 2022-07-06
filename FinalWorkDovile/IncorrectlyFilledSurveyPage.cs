

namespace FinalWorkDovile
{
    public class IncorrectlyFilledSurveyPage
    {
        public static void clickApklausaVasara()
        {
            string locator = "//*[@target='_blank']";
            Common.clickElement(locator);
        }

        public static void switchToNewWindowFromParentWindowByHandle(string parentWindowHandle)
        {
            Common.switchToNewWindowFromParentWindowByHandle(parentWindowHandle);
        }

        public static string getCurrentWindowHandle()
        {
            return Common.getCurrentWindowHandle();
        }

        public static void clickPradeti()
        {
            string locator = "//*[@type='submit']";
            Common.waitForElementToBeClickable(locator);
            Common.clickElement(locator);
        }

        public static void fillLytis()
        {
            string locator = "//*[@value='female']";
            Common.clickElement(locator);
        }

        public static void fillAmzius()
        {
            string locator = "//*[@value='20']";
            Common.clickElement(locator);
        }

        public static void clickTesti()
        {
            string locator = "//*[@name='reg_answer']";
            Common.clickElement(locator);
        }

        public static string getMesaggeAfterTesti()
        {
            string locator = "//*[@class='err_msg2_info']";
            return Common.getElementText(locator);
        }
    }
}
