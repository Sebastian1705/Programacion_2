using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using ClasesInstanciables;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ValidarDniTest()
        {
            //Arrange
            int dni = 35000428;
            Alumno aux = new Alumno(1, "Sebastian", "Aguirre", dni.ToString(), Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            //Act
            int resultado = aux.DNI;

            //Assert
            Assert.AreEqual(dni, resultado);
        }
        
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NewAlumnoTest()
        {
            //Arrange
            Alumno aux = new Alumno(1, "Sebastian", "Aguirre", "35000428", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            //Act

            //Assert
            Assert.IsNotNull(aux.Nombre);
            Assert.IsNotNull(aux.DNI);
            Assert.IsNotNull(aux.Apellido);
            Assert.IsNotNull(aux.Nacionalidad);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void SinProfesorExceptionTest()
        {
            //Arrange
            Universidad aux = new Universidad();

            //Act
            try
            {
                aux += Universidad.EClases.Laboratorio;
            }

            //Assert
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(SinProfesorException));
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Excepciones.DniInvalidoException))]
        public void AlumnoRepetidoExceptionTest()
        {
            Alumno aux = new Alumno(1, "Sebastian", "Aguirre",null, Persona.ENacionalidad.Argentino, 
                                    Universidad.EClases.Laboratorio);
        }

    }
}
