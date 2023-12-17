using EnsekTest.ComponentHelper;
using EnsekTest.PageObject;
using EnsekTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsekTest.TestScripts.Testcase
{
    [TestClass]
    public class DashboardTest
    {
        [TestMethod]
        public void Register()
        {

            //Scenario:
            //The user land on the website and try to register using a wrong credential

            //Given: I am on the company website
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homepage = new HomePage();

            Assert.IsTrue(HomePage.homepagetitle, "User is not on ENSEK website");

            //When I register using wrong credential
            homepage.GoToRegister();

            RegisterPage register = new RegisterPage();
            register.GetregisterUsingWrongCredential();

            //Then: User is not register
            Assert.IsTrue(RegisterPage.wrongcredential, "Wrong credential used");

        }
    }
}
