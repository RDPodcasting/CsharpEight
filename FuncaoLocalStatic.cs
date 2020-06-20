using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewVersion
{
    enum CalculationType
    {
        Sum,
        Multiply
    }
    class FuncaoLocalStatic
    {
        int Calculate(int numberA,int numberB, CalculationType calculationType)
        {
            if (CalculationType.Sum == calculationType)
                return Sum(numberA, numberB);
            else if (CalculationType.Multiply == calculationType)
                return Multiply(numberA, numberB);

            static int Sum(int numberA, int numberB) => numberA + numberB;
            static int Multiply(int numberA, int numberB) => numberA * numberB;

            return 0;
        }

        [Test]
        public void FuncaoLocalStaticTest()
        {
            int result = Calculate(10, 2, CalculationType.Multiply);
            Assert.That(result, Is.EqualTo(20));

            result = Calculate(10, 2, CalculationType.Sum);
            Assert.That(result, Is.EqualTo(12));
        }

    }
}
