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
    }
}
