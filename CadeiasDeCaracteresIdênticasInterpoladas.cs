using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewVersion
{
    class CadeiasDeCaracteresIdênticasInterpoladas
    {
        [Test]
        public void CadeiasDeCaracteresIdênticasInterpoladasTest()
        {
            var price = 10;

            var message = @$"O valor do item é de {price.ToString()}!
                Boas compras!";

        }

    }
}
