using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNewVersion
{
    class IndicesEintervalos
    {
        [Test]
        public void IndicesEintervalosTest()
        {
            var words = new string[]
            {
                "t",
                "tt",
                "ttt",
                "tttt"
            };

            Assert.That(words[^1], Is.EqualTo("tttt"));
        }

    }
}
