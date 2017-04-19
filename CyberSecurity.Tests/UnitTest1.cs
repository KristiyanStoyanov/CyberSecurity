using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.WebDriver.Equip.Settings;
using Selenium.WebDriver;
using OpenQA.Selenium.Chrome;
using CyberSecurity.Controllers;
using CyberSecurity.Models;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.PhantomJS;
using chromypack;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;


namespace CyberSecurity.Tests
{
    [TestClass]
    public class WebApplication
    {
        public  ChromeDriver webDriver = new ChromeDriver();

        [TestCategory("Manual QA Front End")]
        [TestMethod]
        public void NavigateToAssessmentCenter( )
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://localhost/CyberSecurity");
            webDriver.FindElementByPartialLinkText("Assesment Center").Click();
        }

        [TestCategory("Manual QA Front End")]
        [TestMethod]
        public void OpenWebApplication( )
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://localhost/CyberSecurity");
            webDriver.FindElementByPartialLinkText("Home").Click();
        }
    }

    [TestClass]
    public class WebApplicationCore
    {
        public ChromeDriver webDriver = new ChromeDriver();

        [TestCategory("UnitTestAgainstCore")]
        [TestMethod]
        public void TestHomeController()
        {
            QuestionController qController = new QuestionController(); 
        }

        [TestCategory("UnitTestAgainstCore")]
        [TestMethod]
        public void TestBusinessQuestionObjectModel()
        {
            QuestionBusinessObject qBusinessObject = new QuestionBusinessObject();

            qBusinessObject.QuestionID = 1;          
        }
    }
}
