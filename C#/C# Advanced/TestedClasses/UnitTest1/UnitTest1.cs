using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestedClasses;
using System;
namespace UnitTest1 {



    [TestClass]

    public class CalcTest {

        Calculator calc;

        [TestInitialize]
        public void initialize() {
            calc = new Calculator();

        }



        [TestMethod]
        public void TestMethod1() {
            Calculator calc = new Calculator();
            int actual = calc.Add(2, 3);
            Assert.AreEqual(5, actual);

        }

        [TestMethod]
        public void AddMinus7andMinus3isMinus10() {
            Calculator calc = new Calculator();
            int actual = calc.Add(-7, -3);
            Assert.AreEqual(-10, actual);

        }

        [TestMethod]
        public void DivideSand0isDivideByZeroException() {
            Assert.ThrowsException<DivideByZeroException>(() => calc.Divide(5, 0));

        }




    }

}
