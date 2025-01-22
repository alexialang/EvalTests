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
       
        public void Add_WithTwoInt_IsTrue(int numberOne, int numberTwo, int expectedValue)
        {
            var result = _operations.Add(numberOne, numberTwo);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [DataRow(2,2, 1)]
       
        public void Divide_WithTwoInt_IsTrue(int numberOne, int numberTwo, int expectedValue)
        {
            var result = _operations.Divide(numberOne, numberTwo);

            Assert.AreEqual(expectedValue, result);
        }


        public void ThrowExceptionifNumberTwoIsZero(int numberOne, int numberTwo)



    }
    
}
