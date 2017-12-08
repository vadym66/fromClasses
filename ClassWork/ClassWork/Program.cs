using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList(new string[] { "1",  "2", "3", "4", "5", "6", "7" });
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
