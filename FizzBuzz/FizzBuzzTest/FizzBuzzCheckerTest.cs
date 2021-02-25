using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FizzBuzz;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzCheckerTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FizzBuzzRenvoieExceptionSiEntreeDe0()
        {
            var retour = FizzBuzzChecker.PlayFizzBuzz(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FizzBuzzRenvoieExceptionSiEntreeInferieureA0()
        {
            var retour = FizzBuzzChecker.PlayFizzBuzz(-5);
        }

        [TestMethod]
        public void FizzBuzzRenvoieFizzSiEntreeEstUnMultipleDe3()
        {
            Assert.AreEqual("Fizz", FizzBuzzChecker.PlayFizzBuzz(3));
        }

        [TestMethod]
        public void FizzBuzzRenvoieBuzzSiEntreeEstUnMultipleDe5()
        {
            Assert.AreEqual("Buzz", FizzBuzzChecker.PlayFizzBuzz(5));
        }

        [TestMethod]
        public void FizzBuzzRenvoieFizzBuzzSiEntreeEstUnMultipleDe3EtDe5()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzzChecker.PlayFizzBuzz(15));
        }

        [TestMethod]
        public void FizzBuzzRenvoieLeNombreEnEntreeSiAucunDesCasPrecedents()
        {
            Assert.AreEqual("2", FizzBuzzChecker.PlayFizzBuzz(2));
        }
    }
}
