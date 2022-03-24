using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;


namespace QATestCode
{
    [TestFixture]
    public class BasePage
    {
        public IWebDriver _webDriver;
        public string baseUrl;

        public BasePage(string url, IWebDriver driver)
        {
            this.baseUrl = url;
            this._webDriver = driver;
        }

        public BasePage(IWebDriver driver)
        {
            this._webDriver = driver;
        }

        public void cargarPagina()
        {
            _webDriver.Navigate().GoToUrl(this.baseUrl);
            _webDriver.Manage().Window.Maximize();
        }


    

    }
}
