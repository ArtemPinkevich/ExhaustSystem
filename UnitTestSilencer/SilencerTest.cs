using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Silencer;

namespace UnitTestSilencer
{
    [TestClass]
    public class SilencerTest
    {
        [TestMethod]
        public void LengthTest()
        {
            Silencer.Silencer silencer = new Silencer.Silencer();
            double value = 60;

            silencer.Length = value;

            Assert.AreEqual(60, silencer.Length);
        }

        [TestMethod]
        public void WidthTest()
        {
            Silencer.Silencer silencer = new Silencer.Silencer();
            double value = 60;

            silencer.Width = value;

            Assert.AreEqual(60, silencer.Width);
        }

        [TestMethod]
        public void HeightTest()
        {
            Silencer.Silencer silencer = new Silencer.Silencer();
            double value = 60;

            silencer.Height = value;

            Assert.AreEqual(60, silencer.Height);
        }
    }
}
