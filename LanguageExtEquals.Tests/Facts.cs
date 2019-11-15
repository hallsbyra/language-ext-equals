using System.Collections.Generic;
using Xunit;
using static LanguageExt.Prelude;

namespace LanguageExtEquals
{
    public class Facts
    {
        [Fact]
        public void Test()
        {
            var i1 = Right(1);
            var i2 = Right(1);
            DefaultEqualityComparer_Equals(i1, i2);

            var a1 = new { x = 1 };
            var a2 = new { x = 1 };
            DefaultEqualityComparer_Equals(a1, a2);

            var r1 = Right(a1);
            var r2 = Right(a2);
            DefaultEqualityComparer_Equals(r1, r2);
        }

        static void DefaultEqualityComparer_Equals<T>(T t1, T t2) =>
            Assert.True(EqualityComparer<T>.Default.Equals(t1, t2));
    }
}
