using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //Suma1
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int number1 = 15;
            int number2 = 52;
            int expected = 67;
            //Act
            int result = Program.Addition(number1, number2);
            //Assert
            Assert.AreEqual(expected, result);
        }
        //Suma2
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int number1 = 3;
            int number2 = 9;
            int expected = 12;

            int result = Program.Addition(number1, number2);

            Assert.AreEqual(expected, result);
        }
    }
}
