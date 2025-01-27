using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTesting.BLL.Interfaces
{
    public interface ICalculatorService
    {
        int Addition(int nb1, int nb2);
        double Addition(double nb1, double nb2);

        int Substraction(int nb1, int nb2);
        double Substraction(double nb1, double nb2);

        int Multiplication(int nb1, int nb2);
        double Multiplication(double nb1, double nb2);

        double Division(double nb1, double nb2);
    }
}
