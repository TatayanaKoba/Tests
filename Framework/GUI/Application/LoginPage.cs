using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
    public static class LoginPage
    {
        //ELEMENTS
        static readonly By LoginInputfield = By.CssSelector("#username");
        static readonly By Pswinputfield = By.CssSelector("#password");
        static readonly By Loginbutton = By.CssSelector("[name='login']");
        static readonly By AssertText = By.CssSelector(".grid_5 h1");
 



        //METHODS
        public static void Login()
        {
            Log.AddMessageToLogFile("Navigating to the url");
            Browser.Navigatetourl(config.LoginPage.URL);
            Log.AddMessageToLogFile("Site is opened, Checking Login procedure");
            Browser.InputText(config.Userlogin, LoginInputfield);
            Browser.InputText(config.Userpsw, Pswinputfield);
            Log.AddMessageToLogFile("Login and password are entered. Clicking Login button");
            Browser.Click(Loginbutton);
            Log.AddMessageToLogFile("Login button is clicked, waiting for the account page");
            Browser.Wait(AssertText);
            TaninAssert.TextPresent(AssertText, config.LoginPage.SuccessMessages.TextforAssertion);
            Log.AddMessageToLogFile("User is successfully logged in");
        }
    }
}
