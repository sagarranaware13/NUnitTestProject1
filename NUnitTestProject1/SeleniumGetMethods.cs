using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace NUnitTestProject1
{
    public static class SeleniumGetMethods
    {
        /// <summary>
        /// this is extenstion methode to get the text 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetText(this IWebElement element)
        {
            return element.GetAttribute("value");
        }

        /// <summary>
        /// this is extension methode to get value from the drop down 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static string GetTextFromDropDown(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;

        }
    }
}