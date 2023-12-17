using EnsekTest.ComponentHelper;
using EnsekTest.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekTest.PageObject
{
    public class HomePage
    {


        private IWebDriver driver;

        #region Mappings

        [FindsBy(How = How.XPath, Using = "//a[@id='registerLink']")]
        public IWebElement registerLink;

        


        #endregion

        #region Page Initialization
        public HomePage()
        {
            PageFactory.InitElements(ObjectRepository.driver, this);
        }

        #endregion

      public void GoToRegister()
        {
            registerLink.Click();
        }


        public static bool homepagetitle
        {
            get
            {
                try
                {
                    var homepagetitle  = ObjectRepository.driver.FindElement(By.XPath("//h1[contains(text(),'ENSEK Energy Corp.')]"));
                    return homepagetitle.Displayed;
                }
                catch
                {
                    return false;
                }
            }
        }


    }
}
