using NUnit.Framework;
using System;

namespace TestModule
{
    public class UnitTest
    {
        private Logic obj;
        [SetUp]
        public void Setup()
        {
            obj = new Logic();
        }

        /// <summary>
        /// For integer values of 1,2,3,4 multiply the provided value by 2 and return the result.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expected"></param>
        [Test]
        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(3, 6)]
        [TestCase(4, 8)]
        public void TestA(int value, int expected)
        {
            int multiple = 2;
            int result = obj.Multiplicate(value, multiple);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// For any integer value bigger than 4, multiply the provided value by 3 and return the result.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expected"></param>
        [Test]
        [TestCase(5, 15)]
        [TestCase(6, 18)]
        [TestCase(7, 21)]
        [TestCase(8, 24)]
        [TestCase(9, 27)]
        public void TestB(int value, int expected)
        {
            Assert.Greater(value, 4);

            int multiple = 3;
            int result = obj.Multiplicate( value, multiple);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// for integer values below 1, throw proper exception.
        /// </summary>
        /// <param name="value"></param>
        [Test]
        [TestCase(-2)]
        [TestCase(-1)]
        [TestCase(0)]
        public void TestC(int value)
        {
            Assert.Throws<Exception>(()=> obj.IsValid(value));
        }


        /// <summary>
        /// For any string values convert them to UpperCase.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="expected"></param>
        [Test]
        [TestCase("erick", "ERICK")]
        [TestCase("test", "TEST")]
        public void TestE(string word, string expected)
        {
            Assert.AreEqual(obj.ToUpperCase(word), expected);
        }

        /// <summary>
        ///  For anything else, return the input value itself.
        /// </summary>
        /// <param name="something"></param>
        [Test]
        [TestCase("erick")]
        [TestCase(1)]
        [TestCase(1.5f)]

        public void TestF(object something)
        {
            Assert.AreSame(something, obj.IsEqual(something));
        }
    }
}
