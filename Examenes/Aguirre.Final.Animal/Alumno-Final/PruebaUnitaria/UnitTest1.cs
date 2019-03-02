using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBinario()
        {
            //Arrange
            Humano Seba = new Humano("Seba", DateTime.Now.AddYears(-29), Humano.Ocupacion.Estudiante);
            //Act
            Seba.Guardar("Humano.bin", Seba);
            Humano aux2 = Seba.Leer("Humano.bin");
            //Assert
            Assert.IsTrue(Seba == aux2);
        }

        [TestMethod]
        public void TestXml()
        {
            //Arrange
            Pez nemo = new Pez("Nemo", Pez.PrincipalAlimento.Plancton);
            //Act
            nemo.Guardar("Pez.xml", nemo);
            Pez aux = nemo.Leer("Pez.xml");
            //Assert
            Assert.IsTrue(nemo == aux);
        }
    }
}
