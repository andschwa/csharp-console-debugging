using System;
using System.Runtime.InteropServices;
using Xunit;

namespace TestNamespace
{
    public class TestClass
    {
        [DllImport("libtest.so")]
        public static extern void Abort();

        [Fact]
        public void ThisWillAbort()
        {
            Abort();
            Assert.True(true);
        }
    }
}
