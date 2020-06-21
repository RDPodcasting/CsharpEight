using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewVersion
{
    class AtribuicaoDeUniaoNula
    {
        [Test]
        public void AtribuicaoDeUniaoNulaTest()
        {
            List<int> numbers = null;

            numbers ??= new List<int>() { 1, 2, 4 };
            Assert.That(numbers, Is.Not.Null);
        }
    }
}
