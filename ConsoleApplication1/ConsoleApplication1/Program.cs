using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new CellphoneRepository();
            var cellphone = new CellPhone
            {
                Manufacture = "appe",
                Model = "12",
                Price = 1234.12,
                ID = 1
            };

            var cellphone1 = new CellPhone
            {
                Manufacture = "samsing",
                Model = "122",
                Price = 12334.12,
                ID = 2
            };

            var cellphone2 = new CellPhone
            {
                Manufacture = "weq",
                Model = "1212",
                Price = 1234.12,
                ID = 3
            };
            repository.Add(cellphone);
            repository.Add(cellphone1);
            repository.Add(cellphone2);
            var phones = repository.GetAll();

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }


        }
    }
}
 