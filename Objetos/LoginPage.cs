using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace QATestCode.Objetos
{
    [TestFixture]
    public class LoginPage : BasePage
    {
        public LoginPage(string url, IWebDriver driver) : base(url, driver) { }
        // =============== Selectores Login Oferta Credito ====================
        private By txtUsuario = By.Id("username");
        private By txtPassword = By.Id("password");
        private By btnLogin = By.XPath("//*[@id='login']/button/i");



        // =============== Set Login ====================
        public IWebElement set_txtUsuario() { return _webDriver.FindElement(this.txtUsuario); }
        public IWebElement set_txtPassword() { return _webDriver.FindElement(this.txtPassword); }
        public IWebElement set_btnLogin() { return _webDriver.FindElement(this.btnLogin); }




        public void usuario(string usuario)
        {
            set_txtUsuario().SendKeys(usuario);

        }

        public void password(string password)
        {
            set_txtPassword().SendKeys(password);

        }

        public void clickLogin()
        {
            set_btnLogin().Click();
        }

    }
}

