using EnsekTest.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekTest.ComponentHelper
{
    public class GenericHelper
    {
        //When you use this locator the locator should be unique or else it won't work
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.driver.FindElements(Locator).Count == 1;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator)) // condition to check if the element is present or not
                return ObjectRepository.driver.FindElement(Locator);

            else
                throw new NoSuchElementException("Element not Found :" + Locator.ToString());
        }

    }
}
