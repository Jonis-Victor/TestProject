using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Core;

namespace TestProject2.Page
{
    class ValidaCepPage : Begin
    {
        public void PreencheCep()
        {
            EscreveTexto("//*[@id='endereco']", "06397270");
        }

        public void ClicaBtnBusca()
        {
            ClicaElemnto("//*[@id='btn-pesquisar']");
        }

        public void ValidaResulado()
        {
            ValidaDados("/html/body/main/form/div[1]/div[2]/div/div[4]/table/tbody/tr/td[1]", "Rua Pequim");
        }
    }
}
