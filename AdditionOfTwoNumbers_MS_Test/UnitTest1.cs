using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionOfTwoNumbers;

namespace AdditionOfTwoNumbers_MS_Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly AdditionOfTwoNumbers.Program program;
        public UnitTest1()
        {
            program = new AdditionOfTwoNumbers.Program();

        }
        [TestMethod]
        public void TestMethod1()
        {
            int numOne = 5;
            int numTwo = 10;
            int result = program.Add(numOne,numTwo);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMethod2()
        {

            int numOne = 5;
            int numTwo = 5;
            int result = program.Add(numOne, numTwo);
            Assert.AreEqual(15, result);
        }

    }
}
