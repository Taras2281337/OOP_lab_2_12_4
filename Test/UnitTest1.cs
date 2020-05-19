using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplicationTest()
        {
            Assert.AreEqual(0, OOP_lab_2_12_4.Program.Multiplication(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }

        [TestMethod]
        public void SumTest()
        {
            Assert.AreEqual(54, OOP_lab_2_12_4.Program.Sum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }
    }
}
