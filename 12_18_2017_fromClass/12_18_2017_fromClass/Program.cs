using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _12_18_2017_fromClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "qweqwe@.gmai.qwe" };
            const string pattern = @"^\[a-z]\@\[a-z]\.\[a-z]$";
            foreach (var value in values)
            {
               if( Regex.IsMatch(value, pattern))
                {
                    Console.WriteLine("true"); 
                }
               else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
