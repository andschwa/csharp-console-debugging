using System;
using Xunit;

namespace TestNamespace
{
    public class TestClass
    {
        [Fact]
        public void ThisWillFail()
        {
            Assert.True(false);
        }
    }
}
