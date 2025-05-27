using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_2311104065; // namespace dari project utama
using System.Windows.Forms;

namespace modul12_2311104065_Test // sesuaikan dengan nama project test kamu
{
    [TestClass]
    public class PangkatTests
    {
        [TestMethod]
        public void TestPangkat_Normal()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(2, 3); // 2^3 = 8
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestPangkat_BIsZero()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(5, 0); // 5^0 = 1
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestPangkat_NegativeExponent()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(4, -2);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestPangkat_ExponentTooLarge()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(2, 11); // b > 10
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestPangkat_BaseTooLarge()
        {
            var form = new Form1();
            int result = form.CariNilaiPangkat(101, 2); // a > 100
            Assert.AreEqual(-2, result);
        }

        }
    }