
using FinalWorkDovile;
using NUnit.Framework;

namespace Tests
{
    public class FillCreatedSurvey
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://www.manoapklausa.lt/login/");
        }

        [Test]
        public static void correctlyFillCreatedSurvey()
        {
            Common.login();

            FillCreatedSurveyPage.clickApklausaVasara();

            string parentWindowHandle = FillCreatedSurveyPage.getCurrentWindowHandle();
            string newWindowHandle;
            FillCreatedSurveyPage.switchToNewWindowFromParentWindowByHandle(parentWindowHandle);
            newWindowHandle = FillCreatedSurveyPage.getCurrentWindowHandle();

            FillCreatedSurveyPage.clickPradeti();
            FillCreatedSurveyPage.fillLytis();
            FillCreatedSurveyPage.fillAmzius();
            FillCreatedSurveyPage.fillGyvenamojiVieta();
            FillCreatedSurveyPage.clickTesti();
            FillCreatedSurveyPage.clickAtsakymas3CheckBox();
            FillCreatedSurveyPage.clickTestiApklausa();

            string expectedMessage = "Ačiū už tavo atsakymus ir noriu parekomenduoti šį tinklapį - paprasta kurti apklausas su ManoApklausa.lt!";
            string actualMessage = FillCreatedSurveyPage.getMesaggeAfterTestiApklausa();
            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }
        [TearDown]
        public static void close()
        {
            Driver.closeDriver();
        }
    }
}
