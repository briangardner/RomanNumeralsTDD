using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RomanNumerals;

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class RomanNumeralGeneratorTests
    {
        [Test]
        public void Should_Throw_Exception_When_Number_Is_Negative()
        {
            //Arrange
            var generator = new RomanNumeralGenerator();

           
            try
            {
                //act
                string result = generator.GetRomanNumeral(-1);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Must provide a positive number between 1 and 50", ex.Message);
            }
        }

        [Test]
        public void Should_Throw_Exception_When_Number_Is_Zero()
        {
            //Arrange
            var generator = new RomanNumeralGenerator();
            try
            {
                //act
                var result = generator.GetRomanNumeral(0);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("Must provide a positive number between 1 and 50", ex.Message);
            }
        }

        [Test]
        public void Should_Throw_Exception_When_Number_Is_Greater_Than_50()
        {
            var generator = new RomanNumeralGenerator();
            try
            {
                //act
                var result = generator.GetRomanNumeral(51);
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("Must provide a positive number between 1 and 50", ex.Message);
            }
        }

        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("IV", 4)]
        [TestCase("XVII", 17)]
        [TestCase("VIII", 8)]
        [TestCase("XLIX", 49)]
        public void Should_Return_Correct_Numeral(string numeral, int number)
        {
            //Arrange
            var generator = new RomanNumeralGenerator();

            //Act
            var result = generator.GetRomanNumeral(number);

            //Assert
            Assert.AreEqual(numeral, result);
        }
    }
}
