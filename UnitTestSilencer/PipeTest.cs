using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Silencer;

namespace UnitTestSilencer
{
    [TestClass]
    public class PipeTest
    {
        [TestMethod]
        public void DiameterTest()
        {
            Pipe pipe = new Pipe();
            double value = 60;

            pipe.Diameter = value;
            Assert.AreEqual(60, pipe.Diameter);
        }

        [TestMethod]
        public void InnerDiameterTest()
        {
            Pipe pipe = new Pipe();
            double value = 60;

            pipe.InnerDiameter = value;
            Assert.AreEqual(60, pipe.InnerDiameter);
        }

        [TestMethod]
        public void BendTest()
        {
            Pipe pipe = new Pipe();
            Bend bend = new Bend();
            double value = 60;

            bend.Angle = value;
            pipe.Bend = bend;

            Assert.AreEqual(60, pipe.Bend.Angle);
        }
    }
}
