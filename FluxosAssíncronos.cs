using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNewVersion
{
    class FluxosAssíncronos
    {
        public async IAsyncEnumerable<int> GetNumbers()
        {
            for(int i = 0; i<20;i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        [Test]
        public async Task FluxosAssíncronosTest()
        {
            await foreach(var number in GetNumbers())
            {
                Debug.WriteLine(number);
            }
        }
    }
}
