using System;
using Bonus01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bonus01Test
{
    [TestClass]
    public class BonusTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var testA = 95;
            var testB = 85;
            var testC = 75;
            var testD = 65;
            var testF = 55;

            //Act
            var sut = new Grade();
            var gradeAresult = sut.FindGrade(testA);
            var gradeBresult = sut.FindGrade(testB);
            var gradeCresult = sut.FindGrade(testC);
            var gradeDresult = sut.FindGrade(testD);
            var gradeFresult = sut.FindGrade(testF);

            //Assert
            Assert.AreEqual("A", gradeAresult);
            Assert.AreEqual("B", gradeBresult);
            Assert.AreEqual("C", gradeCresult);
            Assert.AreEqual("D", gradeDresult);
            Assert.AreEqual("F", gradeFresult);

        }
    }
}
