using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekTest.ComponentHelper
{
    public class TextHelper
    {
        private static IWebElement element;

        public static void TypeInTextBox(By Locator, string Text)
        {
            element = GenericHelper.GetElement(Locator);
            element.SendKeys(Text);

        }

        public static void ClearTextBox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);

        }


    }
}
