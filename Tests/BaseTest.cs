using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalWorkDovile;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Tests
{
    public class BaseTest
    {
        [SetUp]
        public static void setup()
        {
            Driver.setDriver();
            Driver.open("https://www.manoapklausa.lt/login/");
        }

        [TearDown]
        public static void close()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.takeScreenshot();
            }

            Driver.closeDriver();
        }
    }
}
