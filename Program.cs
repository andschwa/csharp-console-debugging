using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TestNamespace
{
    public class TestClass
    {
        [Fact]
        public void ThisWillPass()
        {
            Assert.True(true);
        }

        [Fact]
        public void ThisWillFail()
        {
            Assert.True(false);
        }

        [DllImport("libtest.so")]
        public static extern void Abort();

        [Fact]
        public void ThisWillAbort()
        {
            Abort();
            Assert.True(true);
        }

        [Fact]
        public void ThisShouldPass()
        {
            Assert.True(true);
        }

        [Fact]
        public void ThisShouldFail()
        {
            Assert.True(false);
        }
    }
}
