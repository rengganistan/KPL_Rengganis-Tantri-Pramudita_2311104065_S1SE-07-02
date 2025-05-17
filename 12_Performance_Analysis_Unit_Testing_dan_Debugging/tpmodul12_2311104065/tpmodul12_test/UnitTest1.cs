using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104065; // pastikan ini sesuai dengan nama project utama kamu

namespace tpmodul12_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBilanganNegatif()
        {
            Form1 form = new Form1();
            string hasil = form.CariTandaBilangan(-5);
            Assert.AreEqual("Negatif", hasil);
        }

        [TestMethod]
        public void TestBilanganNol()
        {
            Form1 form = new Form1();
            string hasil = form.CariTandaBilangan(0);
            Assert.AreEqual("Nol", hasil);
        }

        [TestMethod]
        public void TestBilanganPositif()
        {
            Form1 form = new Form1();
            string hasil = form.CariTandaBilangan(10);
            Assert.AreEqual("Positif", hasil);
        }
    }
}
