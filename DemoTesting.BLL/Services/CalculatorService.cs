using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoTesting.BLL.Interfaces;

namespace DemoTesting.BLL.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Addition(int nb1, int nb2)
        {
            throw new NotImplementedException();
        }

        public double Addition(double nb1, double nb2)
        {
            throw new NotImplementedException();
        }

        public double Division(double nb1, double nb2)
        {
            throw new NotImplementedException();
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
