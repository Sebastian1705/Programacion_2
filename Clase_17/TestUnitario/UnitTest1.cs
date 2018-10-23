using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase_17;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MiLista<int> a = null;
            try
            {
                a.DatoDeMiLista = 3;
            }
            catch(Exception e)
            {
                //Assert.IsTrue(GetType() == typeof(Exception));
            }
            //Assert.Fail();
        }

        [TestMethod]
        public void TestMethod2()
        {

        }
    }
}
