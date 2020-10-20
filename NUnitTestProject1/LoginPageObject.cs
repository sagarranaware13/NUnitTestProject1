using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace NUnitTestProject1
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

        [FindsBy(How =How.Name, Using = "UserName")]
        public IWebElement Username { get; set; }


        [FindsBy(How =How.Name, Using = "Password")]
        public IWebElement Password { get; set; }


        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }
        

        public EAPageobjects LoginMethod(String username, string password)
        {
            
            Username.EnterText(username);
            Password.EnterText(password);
            BtnLogin.ClickElement();

            return new EAPageobjects();
        }

    }
}