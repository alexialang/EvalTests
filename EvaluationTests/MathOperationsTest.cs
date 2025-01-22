using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSampleCode;

namespace MathsOperationsTest
{


    [TestClass]
    public class MathsOperationsTest
    {
        private MathOperations _operations;
        [TestInitialize]
        public void Init()
        {
            _operations = new MathOperations();
        }

        [TestMethod]
        [DataRow(1,1, 2)]
        [DataRow(5, 3, 8)]

        public void Add_WithTwoInt_IsTrue(int numberOne, int numberTwo, int expectedValue)
        {
            var result = _operations.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [DataRow(2,2, 1)]
        [DataRow(9, 3, 3)]

        public void Divide_WithTwoInt_IsTrue(int numberOne, int numberTwo, int expectedValue)
        {
            var result = _operations.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [DataRow(2,0)]
        public void ThrowExceptionifNumberTwoIsZero(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _operations.Divide(numberOne, numberTwo));
        }



    }
    
}
