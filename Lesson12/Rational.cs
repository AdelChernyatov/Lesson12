using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    [DeveloperInfo("Владимир",20,11,2010)]
    class Rational
    {
        private int numerator;
        private int denominator;
        public Rational(int num, int denom)
        {
            if (denom != 0)
            {
                numerator = num;
                denominator = denom;
            }
            else { Console.WriteLine("Такой дроби не существует"); }
        }
        
    }
}
