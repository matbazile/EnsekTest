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

        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        public IWebElement textBoxFullName;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement submit;

        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        public IWebElement email;





        #endregion

        #region Page Initialization
        public HomePage()
        {
            PageFactory.InitElements(ObjectRepository.driver, this);
        }

        #endregion

        public void Fill()
        {
            //Thread.Sleep(3000);
            textBoxFullName.SendKeys("Testing");
            email.SendKeys("test@gmail.com");
            BrowserHelper.scrollDown();
            submit.Click();
            BrowserHelper.scrollUp();

        }


        public static bool Submitted
        {
            get
            {
                try
                {
                    var confirmation = ObjectRepository.driver.FindElement(By.XPath("//div[contains(@class,'alert-success')]"));
                    return confirmation.Displayed;
                }
                catch
                {
                    return false;
                }
            }
        }


    }
}
