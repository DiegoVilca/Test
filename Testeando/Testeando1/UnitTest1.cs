using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testeando;

namespace Testeando1
{
    [TestClass]
    public class UnitTest1
    {

        //Debe instanciar el obj est
        [TestMethod]
        public void InstanciaEstacionamiento()
        {
            Estacionamiento est = new Estacionamiento();

            Assert.IsNotNull(est);
    
        }


        //
        [TestMethod]
        public void listadoInstanciado()
        {
            Estacionamiento est = new Estacionamiento();

            Assert.IsNotNull(est.listaVehiculo);

        }
    }
}
