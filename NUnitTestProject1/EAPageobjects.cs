using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace NUnitTestProject1
{
    class EAPageobjects
    {
        public EAPageobjects()
        {
            PageFactory.InitElements(PropertyCollection.driver, this);
        }

    
        [FindsBy(How =How.Id, Using = "titleid")]
        public IWebElement DdtitleID { get; set; }

        
        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement TextBoxInitial { get; set; }


        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement TxtFirstName { get; set; }


        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement TxtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement ButtonSave { get; set; }


        public void FilluserForm(string initial, string fname, string lname)
        {
            
            TextBoxInitial.EnterText(initial);
            TxtFirstName.EnterText(fname);
            TxtMiddleName.EnterText(lname);
            ButtonSave.ClickElement();
            
        }

        public void WaitForPagetoLoad()
        {
            new WebDriverWait(PropertyCollection.driver, TimeSpan.FromSeconds(60)).Until(
            d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

        }

    }
}
