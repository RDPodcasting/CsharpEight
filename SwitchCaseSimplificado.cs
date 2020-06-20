using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CsharpNewVersion
{
    enum MyColor
    {
        Yellow,
        Black,
        Red
    }
    class SwitchCaseSimplificado
    {
        Color GetColor(MyColor myColor) =>
            myColor switch
            {
                MyColor.Black => Color.Black,
                MyColor.Yellow => Color.Yellow,
                MyColor.Red => Color.Red,
                _ => throw new Exception("Cor não implementada!")
            };

        [Test]
        public void SwitchCaseSimplificadoTest()
        {
            var selectedColor = GetColor(MyColor.Black);

            Assert.That(Color.Black, Is.EqualTo(selectedColor));
        }
    }
}
