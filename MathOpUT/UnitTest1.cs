using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOp;

namespace MathOpUT
{
    [TestClass]
    public class MathopUT
    {

        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(5 + 5, Mathop.Sum(5,5));
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(5 - 3, Mathop.Subtract(5, 3));
        }

        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(5 * 3, Mathop.Multiply(5, 3));
        }

        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(10 / 5, Mathop.Divide(10, 5));
        }
    }
}
