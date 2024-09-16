using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MilyutinNM.Sprint0.Task4.V0.Lib;

namespace Tyuiu.MilyutinNM.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheackedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheackedAdditionInvalid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheackedSubtractionValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheackedMultiplicationInvalid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
