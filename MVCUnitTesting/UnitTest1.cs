using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCViewDemo.Controllers;

namespace MVCUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IndexTest()
        {
            HomeController homeController = new HomeController();
            ViewResult? result = homeController.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void MyControllerTest() { 
            HomeController homeController = new HomeController();
            ViewResult? result = homeController.MyController() as ViewResult;
            Assert.AreEqual("Testing method1", result.ViewData["Message"]);
        
        }
    }
    [TestClass]
    public class EmployeeControllerTesti
    {
        [TestMethod]
        public void EmployeeTest()
        {
            EmployeeController empController = new EmployeeController();
            ViewResult? result = empController.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}