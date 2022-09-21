using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ekzKD;

namespace ekzKD_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ekzKD.test prog = new ekzKD.test();
            prog.minus(9, 10, 3);
        }
    }
}
