using EnsekTest.Settings;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace EnsekTest.PageObject
{
    public class RegisterPage
    {
        #region Mappings

        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        public IWebElement emailInput;

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        public IWebElement passwordInput;

        [FindsBy(How = How.XPath, Using = "//input[@id='ConfirmPassword']")]
        public IWebElement confirmPasswordInput;


        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement registerBtn;


        #endregion




        #region Page Initialization
        public RegisterPage()
        {
            PageFactory.InitElements(ObjectRepository.driver, this);
        }

        #endregion

        #region Method

        public void GetregisterUsingWrongCredential()
        {
            emailInput.SendKeys("test@gmail.com");
            passwordInput.SendKeys("12345");
            confirmPasswordInput.SendKeys("12345");

            registerBtn.Click();
        }


        #endregion


        public static bool wrongcredential
        {
            get
            {
                try
                {
                    var homepagetitle = ObjectRepository.driver.FindElement(By.XPath("/html/body/div[2]/form/div[1]"));
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
