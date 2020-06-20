using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewVersion
{
    ref struct MyStruct
    {
        public void Dispose()
        {
            EstruturasRefDescartáveis.Dead = true;
        }
    }

    class EstruturasRefDescartáveis
    {
        public static bool Dead { get; set; } = false;

        [Test]
        public void EstruturasRefDescartáveisTest()
        {
            using (var myStructResponse = new MyStruct())
            {

            }
            Assert.That(Dead, Is.True);
        }

    }
}
