using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSilencer
{
    [TestClass]
    public class DataFormTest
    {
        [TestMethod]
        public void SetParametersTest()
        {
            Silencer.ExhaustSystem exhaustSystem = new Silencer.ExhaustSystem(); 
            exhaustSystem.Silencer.Length = 50;

            Assert.AreEqual(50, exhaustSystem.Silencer.Length);
        }


    }
}
