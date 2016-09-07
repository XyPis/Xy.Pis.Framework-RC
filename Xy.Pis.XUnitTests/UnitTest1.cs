using System;
using Xunit;

namespace Xy.Pis.XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.True(1 == 1);
        }

        [Fact]
        public void TestMethod2()
        {
            Assert.False(2==1);
        }
    }
}
