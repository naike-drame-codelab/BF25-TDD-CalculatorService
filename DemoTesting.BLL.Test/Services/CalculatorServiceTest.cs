﻿using DemoTesting.BLL.Interfaces;
using DemoTesting.BLL.Services;
using DemoTesting.BLL.CustomExceptions;

namespace DemoTesting.BLL.Test.Services
{
    public class CalculatorServiceTest
    {

        #region Tools
        // hiding instance for future-proofing code
        private ICalculatorService GetCalculatorService()
        {
            return new CalculatorService();
        }
        #endregion

        #region Addition
        [Fact]
        // Nomenclature : Functionality - Scenario - Comment
        // Using variables instead of values inside the method
        public void Addition_TwoInteger_Ok()
        {
            // Arrange
            ICalculatorService service = GetCalculatorService();
            const int val1 = 5;
            const int val2 = 2;
            const int expected = 7;

            // Action 
            int actual = service.Addition(val1,val2);

            // Assert
            Assert.Equal(expected, actual);
        }  

        [Fact]
        public void Addition_TwoReal_Ok()
        {
            // Arrange
            ICalculatorService service = GetCalculatorService();
            const double val1 = 0.9;
            const double val2 = 0.3;
            const double expected = 1.2;

            // Action 
            double actual = service.Addition(val1,val2);

            // Assert
            Assert.Equal(expected, actual);
        } 

        [Fact]
        public void Addition_TwoReal_BugPrecision_IEEE754()
        {
            // Arrange
            ICalculatorService service = GetCalculatorService();
            const double val1 = 0.1;
            const double val2 = 0.2;
            const double expected = 0.3;

            // Action 
            double actual = service.Addition(val1,val2);

            // Assert
            Assert.Equal(expected, actual);
        }

        // [Theory] : allows to inject params
        [Theory]
        [InlineData(int.MaxValue, 42)]
        [InlineData(int.MinValue, -42)]
        public void Addition_TwoBigInteger_ExceptionOnOverflow(int val1, int val2)
        {
            // Arrange
            ICalculatorService service = GetCalculatorService();
            //const int val1 = int.MaxValue;
            //const double val2 = 42;

            // Action + Assert
            Assert.Throws<CalculatorOverflowException>(() =>
            {
                service.Addition(val1, val2);
            });
        }


        #endregion

        #region Division
        [Fact]
        public void Division_TwoInteger_Ok()
        {
            ICalculatorService service = GetCalculatorService();
           
            const int val1 = 5;
            const int val2 = 2;
            const double expected = 2.5;

            double actual = service.Division(val1,val2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10.9, 2.3, 4.739)] 
        [InlineData(-5.45, 6.8, -0.801)]
        [InlineData(8.44, -7.412, -1.139)]
        [InlineData(-2.12, -13.984, 0.152)]
        public void Division_TwoReal_Ok(double val1, double val2, double expected)
        {
            ICalculatorService service = GetCalculatorService();
           
            double actual = service.Division(val1,val2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_Zero()
        {
            ICalculatorService service = GetCalculatorService();

            const double val1 = 4.5;
            const double val2 = 0;

            Assert.Throws<CalculatorDivisionPerZeroException>(() =>
            {
                service.Division(val1, val2);
            });
        }

        #endregion

    }
}
