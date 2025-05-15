namespace unit_test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestGrade()
        {
            String result1 = guided_mod12.Program.DetermineGrade(90);
            Assert.AreEqual("A", result1);
        }
    }
}
