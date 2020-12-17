using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumber;

namespace MaxNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC1.1 When Three integers are given to the method and largest number among all numbers is at position 1st, this test case should pass
        /// </summary>
        /// <param name="firstValue">firstValue will be maximum of all three integer values</param>
        [TestMethod]
        [DataRow(643, 353, 532)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionOneShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = firstValue;
            int result = MaximumNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.2 When Three integers are given to the method and largest number among all numbers is at position 2nd, this test case should pass
        /// </summary>
        [TestMethod]
        [DataRow(423, 4453, 532)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionTwoShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = secondValue;
            int result = MaximumNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 When Three integers are given to the method and largest number among all numbers is at position 3rd, this test case should pass
        /// </summary>
        [TestMethod]
        [DataRow(233, 553, 932)]
        public void GivenThreeIntegersWhenMaxIntegerAtPositionThreeShouldReturnThatValue(int firstValue, int secondValue, int thirdValue)
        {
            int expectedResult = thirdValue;
            int result = MaximumNumbers.MaxIntNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.1 here we find max float number in between given three float number
        /// <summary/>
        [TestMethod]
        [DataRow(66.3f, 5.3f, 4.2f)]
        public void GivenThreeFloatWhenMaxFloatAtPositionOneShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = firstValue;
            float result = MaximumNumbers.MaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }
        /// <summary>
        /// TC1.2 here we find max float number in between given three float number
        /// <summary/>
        [TestMethod]
        [DataRow(33.2f, 445.3f, 5.22f)]
        public void GivenThreeFloatWhenMaxFloatAtPositionTwoShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = secondValue;
            float result = MaximumNumbers.MaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// TC1.3 here we find max float number in between given three float number
        /// <summary/>
        [TestMethod]
        [DataRow(63.3f, 6.53f, 93.2f)]
        public void GivenThreeFloatWhenMaxFloatAtPositionThreeShouldReturnThatValue(float firstValue, float secondValue, float thirdValue)
        {
            float expectedResult = thirdValue;
            float result = MaximumNumbers.MaxFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expectedResult, result);
        }

        /// <summary>
        /// Check Maximum String and Return Peach
        /// </summary>
        [TestMethod]
        public void CheckFirstStringWhenGreaterReturnPeach()
        {
            string max = "Peach";
            string Result = MaximumNumbers.StringMaximumNumber("Peach", "Apple", "Banana");
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check MAximum String and Return Strawberry
        /// </summary>
        [TestMethod]
        public void CheckSecondStringWhenGreaterRetrunStrawberry()
        {
            string max = "Strawberry";
            string Result = MaximumNumbers.StringMaximumNumber("Apple", "Strawberry", "Peach");
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check Maximum Sting And Return Peach
        /// </summary>
        [TestMethod]
        public void CheckThirdStringWhenGreaterRetrunPeach()
        {
            string max = "Peach";
            string Result = MaximumNumbers.StringMaximumNumber("Apple", "Banana", "Peach");
            Assert.AreEqual(max, Result);
        }
    }
}
