using Aquality.Selenium.Browsers;
using NUnit.Framework;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace TestProject1
{
    public class Tests
    {
        string envValue = Environment.GetEnvironmentVariable("tetsUrl");

        [Test]
        public void Test1()
        {
            var commonPathToBinFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string fullPathForSavedImage = $@"{commonPathToBinFolder}\tetsImge.jpg";
            
            AqualityServices.Browser.GoTo(envValue);
            AqualityServices.Browser.Maximize();

            var bytes = AqualityServices.Browser.GetScreenshot();

            using (var streamBitmap = new MemoryStream(bytes))
            {
                var img = Image.FromStream(streamBitmap);
                img.Save(fullPathForSavedImage);
            }

            AqualityServices.Browser.Quit();
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("https://learn.javascript.ru/", envValue, "Expected but was error url");
        }
    }
}