using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_46;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Crear un test unitario que valide que la lista de vehículos de la competencia esté instanciada
        /// al crear un nuevo objeto.
        /// </summary>
        [TestMethod]
        public void ListaInstanciada()
        {
            //Arrange
            Competencia c = new Competencia(10, 5, Competencia.TipoDeCompetencia.f1);

            //Assert
            Assert.IsNotNull(c.Competidores);

        }

        /// <summary>
        /// Realizar un test unitario que controle que la excepción CompetenciaNoDisponible se lance al
        /// querer cargar un AutoF1 en una competencia del tipo MotoCross.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void LanzarExcepcionAuto()
        {
            //Arrange
            Competencia c = new Competencia(10, 5, Competencia.TipoDeCompetencia.MotoCross);
            AutoF1 a = new AutoF1(2, "Auto");

            //Act
            bool cargado = (c + a) ? true : false;

        }

        /// <summary>
        /// Realizar otro test que controle que la excepción CompetenciaNoDisponible no se lance al
        /// querer cargar un objeto del tipo MotoCross en una competencia del tipo MotoCross.
        /// </summary>
        [TestMethod]
        public void LanzarExcepcionMoto()
        {
            //Arrange
            Competencia c = new Competencia(10, 5, Competencia.TipoDeCompetencia.MotoCross);
            MotoCross m = new MotoCross(2, "Moto");

            //Act
            bool cargado = (c + m) ? true : false;
        }

        /// <summary>
        /// Comprobar que al cargar un nuevo vehículo en la competencia esté figure en la lista. Utilizar
        /// el operador + y el ==.
        /// </summary>
        [TestMethod]
        public void CompetidorEnLista()
        {
            //Arrange
            Competencia competencia = new Competencia(5, 5, Competencia.TipoDeCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "Kawasaki");

            //Act
            bool cargado = (competencia + moto) ? true : false;

            //Assert
            Assert.IsTrue(competencia == moto);
        }

        [TestMethod]
        public void CompetidorEliminadoDeLista()
        {
            //Arrange
            Competencia competencia = new Competencia(5, 5, Competencia.TipoDeCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "Kawasaki");

            //Act
            bool cargado = (competencia - moto) ? true : false;

            //Assert
            Assert.IsTrue(competencia != moto);
        }

    }
}
