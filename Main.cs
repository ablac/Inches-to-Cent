using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace InchesToCentmeters
{
    class InchesToCentimeterslnteractive
    {
        static void Main(string[] args)
        {

            const double CPI = 2.54;
            double Inches = 0;
            double Cents = 0;

            Write("How many Inches: ");

            Inches = double.Parse(ReadLine());
            Cents = Inches * CPI;

            WriteLine($"{Inches} inches is {Cents} centimeters.");
        }
    }
}