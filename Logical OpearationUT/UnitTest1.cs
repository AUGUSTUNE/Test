using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicalOperation;

namespace LogicalOpearationUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsTwenty()

        {


            Assert.AreEqual(false, Program.IsTwenty(3));


        }

        [TestMethod]
        public void IsThirty()

        {


            Assert.AreEqual(true, Program.IsThirty(3));


        }
        [TestMethod]
        public void Rightshift()
        {
            Assert.AreEqual(1, Program.Shift(8));


        }
    }
}