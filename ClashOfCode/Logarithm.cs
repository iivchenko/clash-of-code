using System;
using NUnit.Framework;

namespace ClashOfCode
{
    [TestFixture]
    public sealed class Logarithm
    {
        [TestCase(1,1)]
        public void Test(int n, int p)
        {
           Console.WriteLine(Math.Log(n, p));
        }
    }
}
