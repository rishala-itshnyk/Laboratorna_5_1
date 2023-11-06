using System;
using NUnit.Framework;

namespace Program.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            double a = 2.0;
            double b = 3.0;
            double c = 1.0;
            double expected = (Math.Sin(a * b * c) * Math.Sin(a * b * c) / (a * a + b * b + c * c));

            double actual = Program.F(a, b, c);
            
            Assert.AreEqual(expected, actual);
        }
    }
}