using System;
using System.Collections.Generic;
using static LanguageExt.Prelude;

namespace LanguageExtEquals
{
    class Program
    {
        static void Main()
        {
            var i1 = Right(1);
            var i2 = Right(1);
            TestEquals(i1, i2);             // True
            TestEqualityComparer(i1, i2);   // True

            var a1 = new { x = 1 };
            var a2 = new { x = 1 };
            TestEquals(a1, a2);             // True
            TestEqualityComparer(a1, a2);   // True

            var r1 = Right(a1);
            var r2 = Right(a2);
            TestEquals(r1, r2);             // False
            TestEqualityComparer(r1, r2);   // False
        }

        static void TestEquals<T>(T t1, T t2) =>
            Console.WriteLine(t1.Equals(t2));

        static void TestEqualityComparer<T>(T t1, T t2) =>
            Console.WriteLine(EqualityComparer<T>.Default.Equals(t1, t2));

    }
}
