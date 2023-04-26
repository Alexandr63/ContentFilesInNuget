using LibC;
using Xunit;

namespace LibCTests
{
    public class LibCTest
    {
        [Fact]
        public void Test()
        {
            ClassLibC lib = new ClassLibC();
            Assert.Equal(3, lib.Exec().Count);
        }
    }
}