using NUnit.Framework;

namespace CsharpNewVersion
{
    class NewPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public NewPoint(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }

    enum Quadrant
    {
        Unknown,
        Origin,
        One,
        Two,
        Three,
        Four,
        OnBorder
    }
    class PadroesPosicionais
    {
        Quadrant GetQuadrant(NewPoint point) =>
            point switch
            {
                (0, 0) => Quadrant.Origin,
                var (x, y) when x > 0 && y > 0 => Quadrant.One,
                var (x, y) when x < 0 && y > 0 => Quadrant.Two,
                var (x, y) when x < 0 && y < 0 => Quadrant.Three,
                var (x, y) when x > 0 && y < 0 => Quadrant.Four,
                var (_, _) => Quadrant.OnBorder,
                _ => Quadrant.Unknown
            };

        [Test]
        public void PadroesPosicionaisTest()
        {
            var point = new NewPoint(1, 2);
            var quadrant = GetQuadrant(point);
            Assert.That(quadrant, Is.EqualTo(Quadrant.One));
        }

    }
}
