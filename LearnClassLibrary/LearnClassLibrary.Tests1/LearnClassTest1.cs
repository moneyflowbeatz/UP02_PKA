using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnClassLibrary.Tests1
{
    [TestClass]
    public class LearnClassTest1
    {
        [TestMethod]
        public void Test_TimeInSecunds()
        {
            // arrange
            int a = 2;
            int b = 3;
            int expected = 7380;


            int totalSec = 7380;
            var expected1 = (2, 3);

            // act
            LearnClass c = new LearnClass();
            int actual = c.TimeInSeconds(a, b);

            var actual1 = c.SecToTime(totalSec);
            // assert
            Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected1, actual1);
        }
    }
}
