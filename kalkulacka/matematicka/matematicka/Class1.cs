using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematicka
{
    public class Class1
    {
        public double add(double FirstValue, double SecondValue)
        {
            return (FirstValue + SecondValue);
        }
        public double sub(double FirstValue, double SecondValue)
        {
            return (FirstValue - SecondValue);
        }
        public double del(double FirstValue, double SecondValue)
        {
            return (FirstValue / SecondValue);
        }
        public double nas(double FirstValue, double SecondValue)
        {
            return (FirstValue * SecondValue);
        }
        public double factorial(double FirstValue)
        {
            if (FirstValue < 0)
            {
                return double.NaN;
            }
            if (FirstValue == 0 || FirstValue == 1)
            {
                return 1;
            }
            return FirstValue * factorial(FirstValue - 1);
        }
        public double PowerA(double a, double b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                double c = a;
                for (; b > 1; b--)
                {
                    c = c * a;
                }
                return c;
            }
        }
        public double modulo(double FirstValue, double SecondValue)
        {
            if (SecondValue == 0)
            {
                return double.NaN;
            }
            else
            {
                return (FirstValue % SecondValue);
            }
        }
        public double odmocneni(double FirstValue, double SecondValue)
        {
            double k = SecondValue;
            for (double i = 0; i < 100; i++)
            {
                k = ((FirstValue - 1) * k / FirstValue) + (SecondValue / (FirstValue * PowerA(k, (FirstValue - 1))));
            }
            return k;
        }

    }
}
