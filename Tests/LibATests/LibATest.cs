using LibA;
using Xunit;

namespace LibATests
{
    public class LibATest
    {
        [Fact]
        public void Test()
        {
            ClassLibA lib = new ClassLibA();
            Assert.Equal(3, lib.Exec().Count);
        }
    }
}