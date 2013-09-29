using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectSky.Tests
{
    [TestFixture]
    public class TestFibonnaci
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [Test]
        public void TestFibonnaciSeries(int fibonnaci, long expected)
        {
            Fibonnaci fib = new Fibonnaci();
            Assert.That(fib.Calculate(fibonnaci), Is.EqualTo(expected));
        }
    }
}
