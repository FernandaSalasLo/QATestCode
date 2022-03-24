using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;

namespace QATestCode.test
{

    [TestFixture]
    public class BaseTest
    {
        public IWebDriver Driver;
        public string baseUrl = "http://the-internet.herokuapp.com/login";
        public static ExtentTest test;
        public static ExtentReports extent;

        [SetUp]
        public void IniciarNavegador()
        {
            new DriverManager().SetUpDriver( new ChromeConfig());
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(baseUrl);
        }

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            ExtentV3HtmlReporter htmlreporter = new ExtentV3HtmlReporter(@"..\..\..\Reportes\Test" + this.GetType().ToString() + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            htmlreporter.Config.DocumentTitle = "QATestCode";
            htmlreporter.Config.ReportName = "QATestCode";
            htmlreporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent.AddSystemInfo("Environment", "local");
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
            extent.AttachReporter(htmlreporter);
        }

        [TearDown]
        public void CerrarDriver()
        {
            Driver.Close();
            Driver.Quit();
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

    }
}