using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Framework.GUI.Application;
using Framework.GUI.Engine;
using Framework.Helper;
using NUnit;
using NUnit.Framework;

namespace Framework.GUI.Tests
{
    public class AccountPageTests
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Open();
            
            
        }

        [Test]
        public void CheckAccountPageSection1Availability()
        {
            LoginPage.Login();
            AccountPage.MyAccountsectionavailability();
        }

        [Test]
        public void CheckThisiconsMeanSection1Availability()
        {
            LoginPage.Login();
            AccountPage.ThisiconsMeansectionavailability();

        }

        [Test]

        public void CheckEditPagecanbeopened()
        {
            LoginPage.Login();
            AccountPage.EditAccount();
        }

        [Test]

        public void CancelButtonfunctionality()
        {
            LoginPage.Login();
            AccountPage.EditAccount();
            AccountPage.CancelEditAccount();
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Close();
        }
    }
}
