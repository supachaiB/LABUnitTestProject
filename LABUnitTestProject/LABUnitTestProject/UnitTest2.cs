using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LABUnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Test_gradeCalculate()
        {
            AssignmentClass ac = new AssignmentClass();
            string result = ac.gradeCalculate(80);
            Assert.AreEqual("A", result);

            result = ac.gradeCalculate(-5);
            Assert.AreEqual("F", result);

            result = ac.gradeCalculate(80);
            Assert.AreEqual("A", result);

            result = ac.gradeCalculate(79);
            Assert.AreEqual("B+", result);

            result = ac.gradeCalculate(49);
            Assert.AreEqual("F", result);
        }

        [TestMethod]
        public void Test_Distance()
        {
            AssignmentClass ac = new AssignmentClass();
            double result = ac.getDistance(3, 2, 7, 8);           
            Assert.AreEqual(7.21, result);

            result = ac.getDistance(-3, 2, 7, -8);
            Assert.AreEqual(14.14, result);

            result = ac.getDistance(-3, -2, -7, -8);
            Assert.AreEqual(7.21, result);

            result = ac.getDistance(3, -2, -7, 8);
            Assert.AreEqual(14.14, result);
        }

        [TestMethod]
        public void Test_Factorial()
        {
            AssignmentClass ac = new AssignmentClass();
            int fact5 = 5;
            int result = ac.getFactorial(fact5);
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void Test_Assignment_4()
        {
           /* AssignmentClass ac = new AssignmentClass();
            bool result = ac.checkPassword("abc123");
            Assert.AreEqual(false, result);

            result = ac.checkPassword("abc12345");
            Assert.AreEqual(true, result);

            result = ac.checkPassword("abcdefgh");
            Assert.AreEqual(false, result);

            result = ac.checkPassword("12345678");
            Assert.AreEqual(false, result);        */
        }
    }
}
