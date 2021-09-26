using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tp5.Linq.Logic;
using Tp5.Linq.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Tp5.Linq.Test
{
    [TestClass]

    public class ConsultasTests
    {
        ConsultasLogic consultaLogic = new ConsultasLogic();

        [TestMethod]
        public void Consulta1Test()
        {
            //Arrange
            Customers customerExpected = new Customers();

            //Act
            Customers customerActual = consultaLogic.Consulta1();

            //Assert
            Assert.AreEqual(customerExpected.GetType(), customerActual.GetType());
        }

        public void Consulta2Test()
        {
            //Arrange
            int stock = 0;
            int stockExpected = 0;

            //Act
            List<Products> products = consultaLogic.Consulta2(stock);

            //Assert
            Assert.AreEqual(stockExpected, products.First().UnitsInStock);
        }


    }
}
