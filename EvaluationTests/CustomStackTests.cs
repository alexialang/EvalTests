using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvaluationSampleCode;
using System;

namespace EvaluationSampleCode.Tests
{
    [TestClass]
    public class CustomStackTests
    {
        private CustomStack _stack;

       
        [TestInitialize]
        public void TestInitialize()
        {
            _stack = new CustomStack(); 
        }

        [TestMethod]
        [DataRow(2, 1)]
        public void Push_WithInt_ReturnTrue(int value, int expectedCount)
        {
            _stack.Push(value);
            Assert.AreEqual(expectedCount, _stack.Count());
        }

        [TestMethod]
        [DataRow(1, 2, 2, 1)]
        public void Pop_WithInt_ReturnTrue(int firstValue, int secondValue, int expectedPopResult, int expectedCount)
        {
            _stack.Push(firstValue);
            _stack.Push(secondValue);
            var result = _stack.Pop();
            Assert.AreEqual(expectedPopResult, result);
            Assert.AreEqual(expectedCount, _stack.Count());
        }

        [TestMethod]
        [DataRow(0)]
        public void Pop_WithEmpty_ThrowException(int dummyValue)
        {
            var exception = Assert.ThrowsException<CustomStack.StackCantBeEmptyException>(() => _stack.Pop());
          
        }

        [TestMethod]
        public void Count_WithEmpty_ShouldReturnZero()
        {
            Assert.AreEqual(0, _stack.Count());
        }

 
    
    }
}
