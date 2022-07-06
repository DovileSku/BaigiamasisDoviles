
using FinalWorkDovile;
using NUnit.Framework;

namespace Tests
{
    public class AlertInSurveyEdit
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://www.manoapklausa.lt/login/");
        }
        [Test]
        public static void EditCreatedSurveyAlert()
        {
            Common.login();

            AlertInSurveyEditPage.clickTaisyti();
            AlertInSurveyEditPage.clickOkInAlertBox();
            AlertInSurveyEditPage.clickIssaugotiPakeitimus();

            string expectedText = "Mano apklausos";
            string actualText = AlertInSurveyEditPage.getTexteAfterIssaugotiPakeitimus();
            Assert.IsTrue(actualText.Contains(expectedText));
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
