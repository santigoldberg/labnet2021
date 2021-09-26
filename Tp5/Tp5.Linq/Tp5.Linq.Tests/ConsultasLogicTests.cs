using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tp5.Linq.Logic;
using Tp5.Linq.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tp5.Linq.Tests
{
    [TestClass]
    public class ConsultasLogicTest
    {
        ConsultasLogic consultaslogic = new ConsultasLogic();

        [TestMethod]
        public void Consulta1Test()
        {
            //Arrange 
            Customers expected = new Customers();
            

            //Act
            Customers actual = consultaslogic.Consulta1();

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        public void Consulta2Test()
        {
            //Arrange 
            int stock = 0;
            int expected = 0;



            //Act
            List<Products> productos = consultaslogic.Consulta2(stock);


            //Assert
            Assert.AreEqual(expected, productos.First().UnitsInStock);
        }
    }
}
