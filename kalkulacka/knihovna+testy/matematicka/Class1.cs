using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematicka
{
    public class Class1
    {
        /// <summary>
        /// Metoda sečte dvě čísla.
        /// </summary>
        /// <param name="FirstValue">Sčítanec</param>
        /// <param name="SecondValue">Sčítanec</param>
        /// <returns>Vrací součet dvou čísel.</returns>
        public double add(double FirstValue, double SecondValue)
        {
            return (FirstValue + SecondValue);
        }

        /// <summary>
        /// Metoda odečte od prvního čísla druhé.
        /// </summary>
        /// <param name="FirstValue">Menšenec</param>
        /// <param name="SecondValue">Menšitel</param>
        /// <returns>Vrací rozdíl dvou čísel.</returns>
        public double sub(double FirstValue, double SecondValue)
        {
            return (FirstValue - SecondValue);
        }

        /// <summary>
        /// Metododa vydělí první číslo druhým.
        /// </summary>
        /// <param name="FirstValue">Dělenec</param>
        /// <param name="SecondValue">Dělitel</param>
        /// <returns>Vrací podíl dvou čísel.</returns>
        public double del(double FirstValue, double SecondValue)
        {
            return (FirstValue / SecondValue);
        }

        /// <summary>
        /// Matoda násobení
        /// </summary>
        /// <param name="FirstValue">Činitel</param>
        /// <param name="SecondValue">Činitel</param>
        /// <returns>Vrací součin dvou čísel.</returns>
        public double nas(double FirstValue, double SecondValue)
        {
            return (FirstValue * SecondValue);
        }

        /// <summary>
        /// Metoda na výpočet faktoriálu.
        /// Při zadání čísla menšího než je 0 se vypíše NaN, při zadání 0 nebo 1 se vypíše 1.
        /// </summary>
        /// <param name="FirstValue">Číslo</param>
        /// <returns>Vrací faktoriál zadaného čísla.</returns>
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

        /// <summary>
        /// Metoda vypočítá mocninu zadaného čísla.
        /// Když je exponent 0, vrátí se výsledek.
        /// </summary>
        /// <param name="a">Základ</param>
        /// <param name="b">Exponent</param>
        /// <returns>Vrací výsledek umocnění.</returns>
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

        /// <summary>
        /// Metoda modulo počítá zbytek po celočíselném dělení zadaného čísla.
        /// </summary>
        /// <param name="FirstValue">Číslo</param>
        /// <param name="SecondValue">Číslo</param>
        /// <returns>Vrátí zbytek po celočíselném dělení.</returns>
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

        /// <summary>
        /// Metoda vypočítá n-tou odmocninu ze zadaného čísla. 
        /// </summary>
        /// <param name="FirstValue">Základ</param>
        /// <param name="SecondValue">Exponent</param>
        /// <returns>Vrátí výsledek odmony.</returns>
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
