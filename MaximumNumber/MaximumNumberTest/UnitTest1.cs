using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumber;
using System;
namespace MaximumNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC1.1 When Three integers are given to the method and largest number among all numbers is at position 1st, this test case should pass
        /// </summary>
        [TestMethod]
        [DataRow(543, 453, 332)]
        public void WhenMaxIntegerAtPositionOne_ShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = firstValue;
            int result = MaximumNumber.MaximumNumber.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.2 When Three integers are given to the method and largest number among all numbers is at position 2nd, this test case should pass
        /// </summary>

        [TestMethod]
        [DataRow(223, 3453, 432)]
        public void WhenMaxIntegerAtPositionTwo_ShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = secondValue;
            int result = MaximumNumber.MaximumNumber.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 When Three integers are given to the method and largest number among all numbers is at position 3rd, this test case should pass
        /// </summary>
               [TestMethod]
        [DataRow(533, 353, 832)]
        public void WhenMaxIntegerAtPositionThree_ShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = thirdValue;
            int result = MaximumNumber.MaximumNumber.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }
    }
}

