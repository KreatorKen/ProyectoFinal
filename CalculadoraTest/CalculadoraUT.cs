using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraTest
{
    [TestClass]
    public class CalculadoraUT
    {
        [DataRow(4, 3, 7)]
        [DataRow(0, 3, 3)]
        [DataRow(-4, 3, -1)]
        [DataRow(0, 0, 0)]
        [TestMethod]
        public void Suma_RetornaValor(int a, int b, int esperado)
        {
            //Arrange
            //int a = 4;
            //int b = 3;
            //int esperado = 7;

            //Comentario de prueba

            //Actual;
            int actual = clsCalculadora.Suma(a, b);

            //Asert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void Resta_RetornaValor()
        {
            //Arrange
            int a = 10;
            int b = 7;
            int esperado = 3;

            //Actual
            int actual = clsCalculadora.Resta(a, b);

            //Asert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void Multiplicacion_RetornaValor()
        {
            //Arrange
            int a = 4;
            int b = 3;
            int esperado = 12;

            //Actual
            int actual = clsCalculadora.Multiplicacion(a, b);

            //Asert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void Division_RetornaValor()
        {
            //Arrange
            int a = 4;
            int b = 4;
            int esperado = 1;

            //Actual
            double actual = clsCalculadora.Division(a, b);

            //Asert
            Assert.AreEqual(esperado, actual);
        }
    }
}
