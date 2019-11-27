using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameOfLifeTests.NetFramework
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ShouldThrowExceptionIfDividerIsZero()
        {
            int divided = 100;
            int divider = 0;
            Assert.ThrowsException<DivideByZeroException>(() => divided / divider);

        }
    }
}
