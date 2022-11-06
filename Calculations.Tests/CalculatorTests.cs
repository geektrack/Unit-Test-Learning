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
    }
}
