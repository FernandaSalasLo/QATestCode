using QATestCode.Generico;
using AventStack.ExtentReports;
using QATestCode.Objetos;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using QATestCode.test;

namespace QATestCode.Test
{
    [TestFixture]    public class LoginTest : BaseTest
    {
        CargarJson loginData = new CargarJson();
       

        [Test]
        public void UsuarioIncorrecto()
        {

            test = extent.CreateTest("IngresoSitio").Info("UsuarioIncorrecto");
            LoginPage login = new LoginPage(baseUrl, Driver);
                                   
            string usuarioincorrecto = loginData.datos_Login().credenciales.usuarioIncorrecto;
            string password = loginData.datos_Login().credenciales.contrasena;


            try
            {
                login.usuario(usuarioincorrecto);
                login.password(password);
                login.clickLogin();
                Thread.Sleep(2000);
                string file = ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;
                test.Log(Status.Pass, "Se valido usuario incorrecto");
                test.AddScreenCaptureFromBase64String(file);

            }
            catch (System.Exception e)
            {
                String error = Convert.ToString(e);
                Assert.Fail(error);
            }
        }

        [Test]
        public void PasswordIncorrecto()
        {

            test = extent.CreateTest("IngresoSitio").Info("PasswordIncorrecto");
            LoginPage login = new LoginPage(baseUrl, Driver);
                        
            string usuario = loginData.datos_Login().credenciales.usuario;
            string passwordIncorrecto = loginData.datos_Login().credenciales.contrasenaIncorrecta;

            try
            {
                login.usuario(usuario);
                login.password(passwordIncorrecto);
                login.clickLogin();
                Thread.Sleep(2000);
                string file = ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;
                test.Log(Status.Pass, "Se valido Password incorrecto");
                test.AddScreenCaptureFromBase64String(file);
          


            }
            catch (System.Exception e)
            {
                String error = Convert.ToString(e);
                Assert.Fail(error);
            }
        }
    }
}
