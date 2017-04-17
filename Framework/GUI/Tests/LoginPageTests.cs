using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GUI.Application;
using Framework.GUI.Engine;
using Framework.Helper;
using NUnit;
using NUnit.Framework;


namespace Framework.GUI.Tests
{
    public class LoginPageTests
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Open();
        }

        [Test]
        public void CheckLoginPageAvailability()
        {
            LoginPage.Login();
        }

       
        [TearDown]
        public void TearDown()
        {
            Browser.Close();
        }
    }
}
