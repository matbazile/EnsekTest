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
        public void DasbordSignIn()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            HomePage homepage = new HomePage();

           
            Assert.IsTrue(HomePage.Submitted, "Not Submitter");
        }
    }
}
