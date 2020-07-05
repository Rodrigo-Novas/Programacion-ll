using System;
using System.Runtime.CompilerServices;
using Backend;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Testeos_Unitarios
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]

        
        public void TestPaquete()
        {
            //arrange
            Paquete p = new Paquete("san lorenzo", "10000");
            Paquete p2 = new Paquete("san lorenzo", "10000");
            bool retorno;

            //Act
            retorno = p == p2;

            //Assert
            Assert.IsTrue(retorno);

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
