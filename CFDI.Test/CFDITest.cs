using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CFDI.Test
{
    [TestClass]
    public class CFDITest
    {
        [TestMethod]
        public void TestUno()
        {
            var cfdi = new CFDI();
            Assert.IsFalse(cfdi.GetStatus());
        }
    }
}