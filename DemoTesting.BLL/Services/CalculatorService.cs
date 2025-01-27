using DemoTesting.BLL.Interfaces;
using DemoTesting.BLL.CustomExceptions;

namespace DemoTesting.BLL.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Addition(int nb1, int nb2)
        {
            long result = (long)nb1 + nb2;

            if (result != nb1 + nb2)
            {
                throw new CalculatorOverflowException();
            }

            return nb1 + nb2;
        }

        public double Addition(double nb1, double nb2)
        {
            return Math.Round(nb1 + nb2, 3);
        }

        public double Division(double nb1, double nb2)
        {
            if (nb2 == 0)
            {
                throw new CalculatorDivisionPerZeroException();
            }

            return Math.Round(nb1 / nb2, 3);
        }

        #region TODO Later
        public int Multiplication(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }

        public double Multiplication(double nb1, double nb2)
        {
            throw new NotImplementedException();
        }

        public int Substraction(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }

        public double Substraction(double nb1, double nb2)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
