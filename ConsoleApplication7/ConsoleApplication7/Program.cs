using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        struct City : IComparable<City>
        {
            public string Name { get; set; }
            public int Population { get; set; }

          

        }


        static void Main(string[] args)
        {
            City[] city = new City[5];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Create a city");
                Console.WriteLine("Input name:");
                city[i].Name = Console.ReadLine();
                Console.WriteLine("Input population");
                city[i].Population = int.Parse(Console.ReadLine());
            }

            foreach (var item in city)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Population);
            }

        }
    }
}
