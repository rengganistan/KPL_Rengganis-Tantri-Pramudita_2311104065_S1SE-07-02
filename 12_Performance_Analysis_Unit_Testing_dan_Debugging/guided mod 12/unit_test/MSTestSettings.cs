namespace unit_test
{
    [TestClass]
    public sealed class Test1MSTestSetting
    {
        [TestMethod]
        public void TestGrade()
        {
            String result1 = guided_mod12.Program.DetermineGrade(90);
            Assert.AreEqual("A", result1);

            String result2 = guided_mod12.Program.DetermineGrade(80);
            Assert.AreEqual("B", result2);

            String result3 = guided_mod12.Program.DetermineGrade(70);
            Assert.AreEqual("C", result3);

            String result4 = guided_mod12.Program.DetermineGrade(60);
            Assert.AreEqual("D", result4);

            String result5 = guided_mod12.Program.DetermineGrade(0);
            Assert.AreEqual("E", result5);
        }
    }
}
