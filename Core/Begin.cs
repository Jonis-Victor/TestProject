using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject2.Core
{
    class Begin : DSL
    {

        [SetUp]
        public void InicioTeste()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br"); //Busca e abre a URL desejada
            driver.Manage().Window.Maximize(); //Ao abrir, maximiza a janela
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5); //Coloca um intervalo de 5 segundo entre cada ação
            driverQuit = false;
        }

        [Test]
        public void Teste()
        {
        }

        [TearDown]
        public void FinalTeste()
        {
        }
    }
}