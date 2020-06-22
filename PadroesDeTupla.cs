
using NUnit.Framework;

namespace CsharpNewVersion
{
    class PadroesDeTupla
    {
        public decimal GetTax(string state, string city) =>
            (state, city) switch
            {
                ( "SP", "Sorocaba" ) => 10,
                ( "SP", "Ourinhos" ) => 12,
                ( "PR", "Londrina" ) => 13,
                ( _, _ ) => 5
            };

        [Test]
        public void PadroesDeTuplaTest()
        {
            var firstTax = GetTax("SP", "Sorocaba");
            var secondTax = GetTax("SP", "Ourinhos");
            var thirdTax = GetTax("PR", "Londrina");

            Assert.That(firstTax, Is.EqualTo(10));
            Assert.That(secondTax, Is.EqualTo(12));
            Assert.That(thirdTax, Is.EqualTo(13));
        }
    }
}
