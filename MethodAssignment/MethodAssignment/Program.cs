﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempConversion = 0;
            TempConvert newTemp = new TempConvert();
            Console.WriteLine("Enter a temperature as a whole number.");
            int tempInput = Convert.ToInt32(Console.ReadLine());
            tempConversion = newTemp.ToCelsius(tempInput);
            Console.WriteLine(tempInput + " converts to " + tempConversion + " Celsius. \n");


            Console.WriteLine("Enter a temperature as a decimal.");
            double tempInput2 = Convert.ToDouble(Console.ReadLine());
            tempConversion = newTemp.ToCelsius(tempInput2);
            Console.WriteLine(tempInput2 + " converts to " + tempConversion + " Celsius.\n");


            Console.WriteLine("Enter a temperature as a string.");
            string tempInput3 = Console.ReadLine();
            tempConversion = newTemp.ToCelsius(tempInput3);
            Console.WriteLine(tempInput3 + " converts to " + tempConversion + " Celsius.");
            Console.ReadLine();
        }
    }
}
