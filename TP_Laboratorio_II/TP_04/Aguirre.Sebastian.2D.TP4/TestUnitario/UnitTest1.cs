using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using FrmPpal;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaPaquetesInstanciada()
        {
            //Arrange
            Correo c = new Correo();
            List<Paquete> l = null;

            //Act
            l = c.Paquetes;

            //Assert
            Assert.IsNotNull(l);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIDRepetidoException))]
        public void MismoTrackingId()
        {
            //Arrange
            Correo c = new Correo();
            Paquete p1 = new Paquete("Direccion 1", "012-345-6789");
            Paquete p2 = new Paquete("Direccion 2", "012-345-6789");

            //Act
            c += p1;
            c += p2;
            
            //Assert
            //Controlado por la Excepcion.
        }
    }
}
