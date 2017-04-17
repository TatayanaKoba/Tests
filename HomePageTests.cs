using System;
using NUnit.Framework;
public class HomePageTests
{
    [SetUp]
    public void SetUp()
    {
        
    }

    [Test]
    public void CheckHomePageAvailability()
    {
        LoginPage.Login();
    }

    [Test] 
    public void CheckHomePageAvatarIsChanging()
    {
        LoginPage.Login();
        HomePage.ChangeAvatar();
    }
    
    [TearDown]
    public void TearDown()
    {

    }
}
