using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekTest.BaseClasses
{
    public class PageBase
    {
        protected IWebDriver _driver = null;
        protected TestContext _testContext = null;


        public PageBase(IWebDriver driver, TestContext TestContext)
        {
            _driver = driver;
            _testContext = TestContext;
            PageFactory.InitElements(_driver, this);
        }
    }
}

