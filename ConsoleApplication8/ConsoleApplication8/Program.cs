using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication7
{
    class Program
    {
        City[] city = new City[2];
        struct City : IComparable<City>
        {
            public string Name { get; set; }
            public int Population { get; set; }

            public int CompareTo (City other)
            {
                if (this.Population > other.Population) return -1;
                if (this.Population == other.Population) return 0;
                else return 1;
            }

            public static bool operator > (City first, City second)
            {
                return first.CompareTo(second) == 1;
            }
            public static bool operator < (City first, City second)
            {
                return first.CompareTo(second) == -1;
            }

        }


        static void Main(string[] args)
        {
            City[] city = new City[3];
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine("Create a city");
                Console.WriteLine("Input name:");
                city[i].Name = Console.ReadLine();
                Console.WriteLine("Input population");
                city[i].Population = int.Parse(Console.ReadLine());
                Clear();
            }

            for (int i = 0; i < 3; i++)
            {
                city[i].CompareTo(city[i + 1]);
            }
            
            
        }
    }
}
