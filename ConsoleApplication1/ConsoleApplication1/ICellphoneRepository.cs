using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    interface ICellphoneRepository
    {
        void Add(CellPhone phone);
        IEnumerable<CellPhone> GetAll();

        void Remove(int id);
    }
}
