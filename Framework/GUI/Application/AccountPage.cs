using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GUI.Engine;
using Framework.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Framework.GUI.Application
{
    public static class AccountPage
    {
        //ELEMENTS
        static readonly By MyAccountsection = By.CssSelector("aside:nth-child(1)");
        static readonly By ThisIconsMeanSection = By.CssSelector(".legends ul");
        static readonly By ChangeAccountDetails = By.CssSelector("#main li:nth-child(1) a");
        static readonly By EditAccountTitle = By.CssSelector("h1");
        static readonly By FirstName = By.CssSelector("#customers_first_name");
        static readonly By Country = By.CssSelector("#customers_addresses_0_countries_id");
        static readonly By Cancelbutton = By.CssSelector("a.button");
        static readonly string FolderName = Log.GetTestnNameDynamically();
        static bool isLogFolderCreated = Log.InitiateLogging(FolderName);

        //METHODS
        public static void MyAccountsectionavailability()
        {
            Log.AddMessageToLogFile("Checking My Account section availablity");
            TaninAssert.ElementPresent(MyAccountsection);
            Log.AddMessageToLogFile("My Account section is available");

        }

        public static void ThisiconsMeansectionavailability()
        {
            Log.AddMessageToLogFile("Checking This Icons Mean section availability");
            TaninAssert.ElementPresent(ThisIconsMeanSection);
            Log.AddMessageToLogFile("This Icon means section is availble");
        }

        public static void EditAccount()
        {
            Log.AddMessageToLogFile("Trying to click on change account details button");
            Browser.Click(ChangeAccountDetails);
            Log.AddMessageToLogFile("Waiting for Edit Account page");
            Browser.Wait(EditAccountTitle);
            TaninAssert.TextPresent(EditAccountTitle, config.AccountPage.SuccessMessages.TextforAssertion);
            Log.AddMessageToLogFile("Edit Account page is opened");

        }

        public static void CancelEditAccount()
        {
            Log.AddMessageToLogFile("Making changes to the account");
            Browser.CleantheInput(FirstName);
            Browser.InputText(config.AccountPage.FirstName, FirstName);
            Browser.InputText(config.AccountPage.Country, Country);
            Log.AddMessageToLogFile("Changes are entered, cancelling");
            Browser.Click(Cancelbutton);
            Log.AddMessageToLogFile("Changes are canceled");
            Browser.Wait(ChangeAccountDetails);
            TaninAssert.ElementPresent(ChangeAccountDetails);
            Log.AddMessageToLogFile("Account Details page is opened, changes are not saved");
        }

        //TESTS
        
    }
}
