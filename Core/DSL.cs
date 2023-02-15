using OpenQA.Selenium;

namespace TestProject2.Core
{
    class DSL : GlobalVariables
    {
        public void EscreveTexto(string xpath, string value) //Função que interagem com os elementos
        {
            driver.FindElement(By.Id(xpath)).SendKeys(value);
        }
        public void ClicaElemnto(string element)
        {
            driver.FindElement(By.Id(element)).Click();

        }
        public void ValidaDados(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.XPath(xpath)).Text, Does.Contain(value)); //Quem fará a validação da informação será o NUnir com o Does.Contain=("Valor")
        }
    }
}
