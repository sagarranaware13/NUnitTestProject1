using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1
{
    enum PropertyType {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    class PropertyCollection
    {
        // auto implemented properties
        public static IWebDriver driver { get; set; }
    }
}
