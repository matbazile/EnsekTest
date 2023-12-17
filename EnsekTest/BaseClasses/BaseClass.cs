using EnsekTest.Configuration;
using EnsekTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using EnsekTest.CustomException;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekTest.BaseClasses
{

    [TestClass]
    public class BaseClass
    {
    
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized"); // code to maximize the window in Chrome
                                                   // option.AddExtension(@"C:\\Users\mathi\\OneDrive\\Documents\\2020\2023\\SeleniumDriver\\Version85");
            return option;
        }




        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;


        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }


        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {

                case BrowserType.Chrome:
                    ObjectRepository.driver = GetChromeDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.driver = GetFirefoxDriver();
                    break;


                default:
                    throw new NoSuitableDriverFound("Driver not found: " + ObjectRepository.Config.GetBrowser().ToString());


            }

        }

        [AssemblyCleanup]
        public static void TearDown()
        {
            if (ObjectRepository.driver != null)
            {
                ObjectRepository.driver.Close();
                ObjectRepository.driver.Quit();
            }
        }






    }

}

