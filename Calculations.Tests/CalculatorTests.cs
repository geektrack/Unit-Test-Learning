using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTests
    {
        [Fact] //Annotation used to represent a Test
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            //Arrange
            Calculator calculator = new Calculator();
            int expectedResult = 3;
            //Act
            var originalResult = calculator.Add(1, 2);

            //Assert
            Assert.Equal(expectedResult, originalResult);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            //Arrange
            Calculator calculator = new Calculator();
            double expectedResult = 3.914;
            //Act
            var originalResult = calculator.AddDouble(1.35, 2.564);

            //Assert
            Assert.Equal(expectedResult, originalResult);
        }  
        
        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDoubleWithPrecision()
        {
            //Arrange
            Calculator calculator = new Calculator();
            //double expectedResult = 3.914;

            //Act
            var originalResult = calculator.AddDouble(1.35, 2.564);

            //Assert
            Assert.Equal(3.9, originalResult,1); //checks precision upto 1 decimal point
            Assert.Equal(3.91, originalResult,2); //checks precision upto 2 decimal point
            Assert.Equal(3.9, originalResult,0); //checks precision upto 0 decimal point
        }
    }
}
