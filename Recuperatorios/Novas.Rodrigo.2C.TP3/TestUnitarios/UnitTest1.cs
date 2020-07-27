using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivos;
using Clases_Abstractas;
using Clases_Instanciables;
using Excepciones;
using System.Text.RegularExpressions;
namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        
       
            /// <summary>
            /// Comprueba que se haya instanciado atributo Lista de Alumnos
            /// </summary>
        [TestMethod]
        public void InstanciaDeListaAlumno()
        {
            Profesor prof = new Profesor();
            Jornada jornada = new Jornada(Universidad.EClase.Laboratorio, prof);

            Assert.IsNotNull(jornada.Alumnos);
        }
        /// <summary>
        /// Comprueba que se haya hecho la excepcion dni
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void ExcepcionDni()
        {
            Alumno a1 = new Alumno(5, "jose", "cpaz", "absdasdasdas",
            Persona.ENacionalidad.Argentino, Universidad.EClase.Programacion, Alumno.EEstadoCuenta.AlDia);
        }

        /// <summary>
        /// Comprueba que se haya hecho la excepcion Alumno si no se volvio a cargar el mismo alumno
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void ExcepcionAlumnoRepetido()
        {
            Universidad uni = new Universidad();
            Alumno a1 = new Alumno(7, "norberto", "piaza", "40302722",
            Persona.ENacionalidad.Argentino, Universidad.EClase.Programacion, Alumno.EEstadoCuenta.AlDia);

            uni += a1;
            uni += a1;

        }

    }
}


