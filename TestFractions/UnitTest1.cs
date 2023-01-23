using Frazioni;
namespace TestFractions
{
    public class UnitTest1
    {
        [Fact]
        public void testSemplifica()
        {
            Fractions f = new Fractions(14,2);
            f.Semplifica();
            Assert.True(f.Numeratore == 7 && f.Denominatore == 1);
        }
        [Fact]
        public void testSomma()
        {
            Fractions f = new Fractions(14, 2);
            Fractions f2 = new Fractions(5, 3);
            Fractions ris = new Fractions();
            ris=f.Somma(f2);
            Assert.True(ris.Numeratore == 52 && ris.Denominatore == 6);
            ris.Semplifica();
            Assert.True(ris.Numeratore == 26 && ris.Denominatore == 3);
        }
        [Fact]
        public void testSottrai()
        {
            Fractions f = new Fractions(14, 2);
            Fractions f2 = new Fractions(5, 3);
            Fractions ris = new Fractions();
            ris = f.Sottrai(f2);
            Assert.True(ris.Numeratore == 32 && ris.Denominatore == 6);
            ris.Semplifica();
            Assert.True(ris.Numeratore == 16 && ris.Denominatore == 3);
        }
        [Fact]
        public void testMoltiplica()
        {
            Fractions f = new Fractions(14, 2);
            Fractions f2 = new Fractions(5, 3);
            Fractions ris = new Fractions();
            ris = f.Moltiplica(f2);
            Assert.True(ris.Numeratore == 70 && ris.Denominatore == 6);
            ris.Semplifica();
            Assert.True(ris.Numeratore == 35 && ris.Denominatore == 3);
        }
        [Fact]
        public void testDividi()
        {
            Fractions f = new Fractions(14, 2);
            Fractions f2 = new Fractions(5, 3);
            Fractions ris = new Fractions();
            ris = f.Dividi(f2);
            Assert.True(ris.Numeratore == 42 && ris.Denominatore == 10);
            ris.Semplifica();
            Assert.True(ris.Numeratore == 21 && ris.Denominatore == 5);
        }
        [Fact]
        public void testEccezioni()
        {
            Fractions f = new Fractions(14, 0);
            Fractions f2 = new Fractions(5, 3);
            Fractions ris = new Fractions();
            Assert.Throws<Exception>(() => ris = f.Dividi(f2));
        }
    }
}