using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaException;
using CentralitaFormException;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Crear un test unitario que valide que la lista de llamadas de la centralita esté instanciada al
        /// crear un nuevo objeto del tipo Centralita.
        /// </summary>
        [TestMethod]
        public void ListaDeLlamadasInstanciada()
        {
            //Act
            Centralita c = new Centralita("Central Prueba");
            
            //Assert
            Assert.IsNotNull(c.Llamadas);
        }

        /// <summary>
        /// Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
        /// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        /// destino de una llamada Local ya existente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CentralitaException.CentralitaException))]
        public void LanzarCentralitaExcepcion()
        {
            //Arrange
            Centralita c = new Centralita("Central telefonica");
            Local llamada = new Local("Lomas", 7, "Lanus", 1);
            Local duplicada = new Local("Lomas", 5, "Lanus", 2);

            //Act
            c += llamada;
            c += duplicada;
            //Assert
 
        }

        /// <summary>
        /// Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
        /// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        /// destino de una llamada Provincial ya existente.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CentralitaException.CentralitaException))]
        public void LanzarCentralitaExcepcionpProvincial()
        {
            //Arrange
            Centralita c = new Centralita("Central telefonica");
            Provincial llamada = new Provincial("Lomas", 5, "Lanus", Provincial.Franja.Franja_1);
            Provincial duplicada = new Provincial("Lomas", 3, "Lanus", Provincial.Franja.Franja_3);

            //Act
            c += llamada;
            c += duplicada;
            //Assert

        }

        /// <summary>
        /// Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
        /// los mismos datos de origen y destino.Luego comparar cada uno de estos cuatro objetos
        /// contra los demás, debiendo ser iguales solamente las instancias de Local y de Provincial
        /// entre sí.
        /// </summary>
        [TestMethod]
        public void ComparararLlamadas()
        {
            //Arrange
            Local l1 = new Local("Lanus", 5, "Lomas", 2);
            Local l2 = new Local("Lanus", 5, "Lomas", 2);
            Provincial p1 = new Provincial("Lanus", 5, "Lomas", Provincial.Franja.Franja_1);
            Provincial p2 = new Provincial("Lanus", 5, "Lomas", Provincial.Franja.Franja_1);

            //Assert
            Assert.IsTrue(l1 == l2);
            Assert.IsFalse(l1 == p1);
            Assert.IsFalse(l1 == p2);
            Assert.IsFalse(l2 == p1);
            Assert.IsFalse(l2 == p2);
            Assert.IsTrue(p1 == p2);

        }
    }
}
