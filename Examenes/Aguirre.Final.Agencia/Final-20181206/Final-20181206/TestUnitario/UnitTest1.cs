using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSerializarDeserealizar()
        {
            //Arrange
            Xml<Agencia> serializador = new Xml<Agencia>();
            Agencia a = new Agencia("Mi agencia");
            Agencia copia;
            //Act
            serializador.Guardar("Agencia", a);
            copia = serializador.Leer("Agencia");
            //Assert
            Assert.ReferenceEquals(a, copia);
        }
    }
}
