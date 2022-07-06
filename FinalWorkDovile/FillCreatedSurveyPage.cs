

namespace FinalWorkDovile
{
    public class FillCreatedSurveyPage
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

        public static void fillGyvenamojiVieta()
        {
            string locator = "//*[@value='town5']";
            Common.clickElement(locator);
        }

        public static void clickTesti()
        {
            string locator = "//*[@name='reg_answer']";
            Common.clickElement(locator);
        }
        public static void clickAtsakymas3CheckBox()
        {
            string locator = "//*[@value='3']";
            Common.clickElement(locator);
        }

        public static void clickTestiApklausa()
        {
            string locator = "//*[@type='submit']";
            Common.clickElement(locator);
        }

        public static string getMesaggeAfterTestiApklausa()
        {
            string locator = "//*[@class='take_join_text1']";
            return Common.getElementText(locator);
        }
    }
}
