using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    internal class CalculatorClass
    {
        public delegate T Information<T>(T arg1, T arg2);

        public Information<string> info;
        public string Concatenate(string str1, string str2)
        {
            return str1 + str2;
        }

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        }
    }
