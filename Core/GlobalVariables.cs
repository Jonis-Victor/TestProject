using OpenQA.Selenium;

namespace TestProject2.Core
{
    class GlobalVariables 
    {
        //Define "driver" como trigger para os webElements
        public IWebDriver driver;
        //Define "Fechar navegador ao final do teste" como padrão
        public bool driverQuit = true;
    }
}
