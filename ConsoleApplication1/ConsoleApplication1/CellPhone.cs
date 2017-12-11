using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CellPhone
    {
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return $"Manufacture: {Manufacture}\nModel: {Model}\nPrice: {Price}\nID: {ID}";
        }
    }
}
