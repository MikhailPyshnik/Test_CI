using NUnit.Framework;
using System;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string envValue = Environment.GetEnvironmentVariable("tetsUrl");
            Assert.AreEqual("https://learn.javascript.ru/", envValue);
        }
    }
}