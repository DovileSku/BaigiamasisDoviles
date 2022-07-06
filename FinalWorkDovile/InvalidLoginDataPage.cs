

namespace FinalWorkDovile
{
    public class InvalidLoginDataPage
    {
        public static void enterEmail(string email)
        {
            string locator = "//*[@name='login_mail']";
            Common.sendKeysToElement(locator, email);
        }

        public static void enterPassword(string password)
        {
            string locator = "//*[@name='login_pass']";
            Common.sendKeysToElement(locator, password);
        }

        public static void ClickPrisijungtiButton()
        {
            string locator = "//*[@name='submit']";
            Common.clickElement(locator);
        }

        public static string getMessageAfterSubmit()
        {
            string locator = "//*[@class='err_msg']";
            return Common.getElementText(locator);
        }
    }
}
