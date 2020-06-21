using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewVersion
{
    public struct Coords<T>
    {
        public T x;
        public T y;
    }

    class ExpressaoStackalloc
    {
        [Test]
        public void ExpressaoStackallocTest()
        {
            Span<Coords<int>> coordinates = stackalloc[]
            {
                new Coords<int> { x = 0, y = 2 },
                new Coords<int> { x = 50, y = 30 }
            };

            Span<int> numbers = stackalloc[] { 1, 2, 3, 4 };
            var ind = numbers.IndexOfAny(stackalloc[] { 3, 4 });

            Assert.That(ind, Is.EqualTo(2));

        }
    }
}
