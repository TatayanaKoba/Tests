using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GUI.Engine;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Framework.Helper;

namespace Framework.GUI.Engine
{
    public static class Browser
    {
        public static IWebDriver driver;

        public static void Open()
        {
            driver = new ChromeDriver();
        }
        public static void Navigatetourl(string url)
        {
            driver.Navigate().GoToUrl(url);
         }
       
        public static void InputText(string inputvalue, By locator)
        {
            IWebElement LoginField = driver.FindElement(locator);
            LoginField.SendKeys(inputvalue);
        }

        public static void GoBack()
        {
        }

        public static void Refresh()
        {
        }

        public static void Wait(By elementtowait)
        {
            string testname = Log.GetTestnNameDynamically();
            try
            {
                TimeSpan timeToWait = TimeSpan.FromSeconds(5);
                WebDriverWait wait = new WebDriverWait(driver, timeToWait);
                wait.Until(driver => driver.FindElement(elementtowait));
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("no such"))
                {
                    Log.LogSystemInfo(testname, "Cannot find element!");
                    Log.Screenshot();
                }

                else
                {
                    Log.LogSystemInfo(testname, "Some other error!");
                    Log.Screenshot();
                }
            }           
        }

        public static void CleantheInput(By inputlinetoclean)
        {
            IWebElement InputField = driver.FindElement(inputlinetoclean);
            InputField.Clear();
        }

        public static void Click(By locatorofbutton)
        {
            IWebElement Button = driver.FindElement(locatorofbutton);
            Button.Click();
        }

        public static void Close()
        {
            driver.Close();
        }

        
    }

}
