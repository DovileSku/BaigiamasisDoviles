
using FinalWorkDovile;
using NUnit.Framework;

namespace Tests
{
    public class InvalidLoginData : BaseTest
    {

        [Test]
        public static void IncorrectlyFilledLoginFields()
        {
            string expectedEmail = "dovile.skujiene@gmail.com";
            string expectedPassword = "Skujien";
            string expectedMessage = "El. paštas arba slaptažodis yra neteisingi!";

            InvalidLoginDataPage.enterEmail(expectedEmail);
            InvalidLoginDataPage.enterPassword(expectedPassword);
            InvalidLoginDataPage.ClickPrisijungtiButton();
            string actualMessage = InvalidLoginDataPage.getMessageAfterSubmit();

            Assert.IsTrue(actualMessage.Contains(expectedMessage));
        }

       
    }
}
