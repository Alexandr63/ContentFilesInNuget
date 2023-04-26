using LibB;
using Xunit;

namespace LibBTests
{
    public class LibBTest
    {
        [Fact]
        public void Test()
        {
            ClassLibB lib = new ClassLibB();
            Assert.Equal(3, lib.Exec().Count);
        }
    }
}