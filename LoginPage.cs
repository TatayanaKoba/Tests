using System;

public static class LoginPage
{
    //ELEMENTS


    //METHODS
    public static void Login(string username, string password)
    {
        Browser.GoToUrl("");
        Browser.InputText("", "");
        Browser.ClickButton();
        Assert.True();
    }
}
