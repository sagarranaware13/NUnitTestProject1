using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            ExcelUtilClass test = new ExcelUtilClass();
            test.PopulateInCollection(@"D:\test.xlsx");

            string result = test.ReadData(2, "username");

            PropertyCollection.driver = new ChromeDriver();
            PropertyCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
        }   

        [Test]
        public void ExicuteTest()
        {
            LoginPageObject login = new LoginPageObject();
            EAPageobjects EApage=login.LoginMethod("sagar", "ranaware");

            EApage.WaitForPagetoLoad();
            EApage.FilluserForm("Mr", "Sagar", "Ranaware");

        }
               
        [TearDown]
        public void EndTest()
        {
            PropertyCollection.driver.Close();
        }
    }
}