using System;
using System.Runtime.CompilerServices;
using Backend;
using Backend.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Testeos_Unitarios
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]

        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void TestPaquete()
        {
            //arrange
            Correo c = new Correo();
            Paquete p = new Paquete("san lorenzo", "10000");
            Paquete p2 = new Paquete("san lorenzo", "10000");
          
            //Act
            c += p;
            c += p2;
            //Assert
            Assert.Fail();
        }

        
        [TestMethod]
        
        public void TestCorreo  ()
        {
            //arrange
            Correo c = new Correo();
            //assert
            Assert.IsNotNull(c.Paquetes);
        }


    }
}
