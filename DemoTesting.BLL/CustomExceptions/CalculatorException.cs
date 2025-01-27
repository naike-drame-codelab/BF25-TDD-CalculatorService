﻿namespace DemoTesting.BLL.CustomExceptions
{

    public class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message) { }
    }

    public class CalculatorOverflowException : CalculatorException
    {
        public CalculatorOverflowException() : base("Overflow detected !") { }
    }

}
