using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject1
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// this is extension methode to enter value in the text box
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        /// <summary>
        /// this is extension methode to click on the element 
        /// </summary>
        /// <param name="element"></param>
        public static void ClickElement(this IWebElement element)
        {
            element.Submit();
        }

        /// <summary>
        /// this is extension methode to selecting drop down control 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}