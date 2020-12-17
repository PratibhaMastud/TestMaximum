using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumNumber;

namespace MaxNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Check MAximum Number and return the first number is maximum
        /// </summary>
        [TestMethod]
        public void CheckFirstMaximumNumber_WhenGreaterNo_FirstPosition()
        {
            int max = 22;
            int Result = MaximumNumbers<int>.MaxNumber(22, 11, 10);
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check MAximum Number and return the Second number is maximum
        /// </summary>
        [TestMethod]
        public void CheckSecondMaximumNumber_WhenGreaterNo_SecondNumber()
        {
            int max = 24;
            int Result = MaximumNumbers<int>.MaxNumber(22, 24, 10);
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check MAximum Number and return the Third number is maximum
        /// </summary>
        [TestMethod]
        public void CheckThirMaximumNumber_WhenGreaterNo_ThirdNumber()
        {
            int max = 28;
            int Result = MaximumNumbers<int>.MaxNumber(22, 24, 28);
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check Maximum String and Return Peach
        /// </summary>
        [TestMethod]
        public void CheckFirstString_WhenGreater_ReturnPeach()
        {
            string max = "Strawberry";
            string Result = MaximumNumbers<string>.MaxNumber("Strawberry", "Apple", "Peach");
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check MAximum String and Return Strawberry
        /// </summary>
        [TestMethod]
        public void CheckSecondString_WhenGreater_RetrunStrawberry()
        {
            string max = "Strawberry";
            string Result = MaximumNumbers<string>.MaxNumber("Apple", "Strawberry", "Peach");
            Assert.AreEqual(max, Result);
        }

        /// <summary>
        /// Check Maximum Sting And Return Peach
        /// </summary>
        [TestMethod]
        public void CheckThirdString_WhenGreater_RetrunPeach()
        {
            string max = "Peach";
            string Result = MaximumNumbers<string>.MaxNumber("Apple", "Banana", "Peach");
            Assert.AreEqual(max, Result);
        }
    }
}
