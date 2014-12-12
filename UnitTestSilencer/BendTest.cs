using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Silencer;

namespace UnitTestSilencer
{
    [TestClass]
    public class BendTest
    {
        [TestMethod]
        public void AngleTest()
        {
            Bend bend = new Bend();
            double value = 60;

            bend.Angle = value;
            Assert.AreEqual(60, bend.Angle);
        }

        [TestMethod]
        public void RadiusTest()
        {
            Bend bend = new Bend();
            double value = 30;

            bend.Angle = value;
            Assert.AreEqual(30, bend.Angle);
        }

    }
}
