using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberAnalyzer
{
    internal class NumberAnalyzer
    {
        public int Number { get; set; }
        public NumberAnalyzer(int number)
        {
            Number = number;
        }
        public  string GetSign()
        {
            string word = "";
                if (Number > 0)
                {
                return "Number is positive";
                }
                else if (Number < 0)
                {
                    return "Number is negative";
                }
                else
                {
                    return "Number is equal to zero";
                }
        }
        public bool  isEven()
        {
            return Number % 2 == 0;
        }
        public bool  isPrime()
        {
            if (Number < 2)  return false;
            for(int i = 2; i <= Math.Sqrt(Number);i++)
            {
                if( Number % i == 0)
                {
                    return false;
                }else
                {
                    return true;
                }
            }
            return true;
        }
        public void isAnalyze()
        {
            Console.WriteLine($"Number is {Number}, {GetSign()}, Even: {(isEven() ? "Yes" : "No")}, Prime : {(isPrime() ? "Yes" : "No")}");
        }
    }
}
