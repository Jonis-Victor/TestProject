using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Page;

namespace TestProject2.Test
{
     class ValidaCepTest : ValidaCepPage
    {
        [Test]
        public void ValidaCep()
        {
            PreencheCep();
            ClicaBtnBusca();
            ValidaResulado();
        }
    }
}
