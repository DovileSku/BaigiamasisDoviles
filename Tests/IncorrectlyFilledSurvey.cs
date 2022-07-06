
using FinalWorkDovile;
using NUnit.Framework;

namespace Tests
{
    public class IncorrectlyFilledSurvey
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://www.manoapklausa.lt/login/");
        }

        [Test]
        public static void IncorrectlyFillCreatedSurvey()
        {
            Common.login();

            IncorrectlyFilledSurveyPage.clickApklausaVasara();

            string parentWindowHandle = IncorrectlyFilledSurveyPage.getCurrentWindowHandle();
            string newWindowHandle;
            IncorrectlyFilledSurveyPage.switchToNewWindowFromParentWindowByHandle(parentWindowHandle);
            newWindowHandle = IncorrectlyFilledSurveyPage.getCurrentWindowHandle();

            IncorrectlyFilledSurveyPage.clickPradeti();
            IncorrectlyFilledSurveyPage.fillLytis();
            IncorrectlyFilledSurveyPage.fillAmzius();
            IncorrectlyFilledSurveyPage.clickTesti();

            string expectedMessage = "Prašome užpildyti visus laukelius!";
            string actualMessage = IncorrectlyFilledSurveyPage.getMesaggeAfterTesti();
            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }

        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
