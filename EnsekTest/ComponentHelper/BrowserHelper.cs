using EnsekTest.Settings;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekTest.ComponentHelper
{
    public class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.driver.Manage().Window.Maximize();

        }

        public static void GoBack()
        {
            ObjectRepository.driver.Navigate().Back();
        }

        public static void Forward()
        {
            ObjectRepository.driver.Navigate().Forward();
        }

        public static void Refresh()
        {
            ObjectRepository.driver.Navigate().Refresh();

        }

        public static void scrollDown()
        {
            Actions Action = new Actions(ObjectRepository.driver);

            IWebElement text = ObjectRepository.driver.FindElement(By.XPath("//input[@name='name']"));
            IWebElement Commentfield = ObjectRepository.driver.FindElement(By.XPath("//input[@type='submit']"));

            Action.MoveToElement(text).MoveToElement(Commentfield).Perform();
        }

        public static void scrollUp()
        {
            Actions Action = new Actions(ObjectRepository.driver);

            IWebElement text = ObjectRepository.driver.FindElement(By.XPath("//input[@name='name']"));
            IWebElement Commentfield = ObjectRepository.driver.FindElement(By.XPath("//input[@type='submit']"));

            Action.MoveToElement(Commentfield).MoveToElement(text).Perform();
        }


    }
}
