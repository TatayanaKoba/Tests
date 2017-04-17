using Framework.GUI.Engine;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework.Helper
{
    public class TaninAssert
    {
        public static void TextPresent(By someElement, string text)
        {
            IWebElement elementWithText = Browser.driver.FindElement(someElement);
            Assert.IsTrue(elementWithText.Text.Contains(text), "Text is not present!");
        }


        public static void ElementPresent(By someelement)
        {
            IWebElement ElementOnPage = Browser.driver.FindElement(someelement);
            Assert.IsTrue(ElementOnPage.Displayed, "Page is not available");
        }
    }

    
}