using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ConsoleApplication1
{
    class CellphoneRepository : ICellphoneRepository
    {
        private const string RepositryFilePath = @"C:\Users\Student\Desktop\temp\CellPhoneFile.txt";
        public void Add(CellPhone phone)
        {
            var phoneString = JsonConvert.SerializeObject(phone);
            File.AppendAllLines(RepositryFilePath,new []{ phoneString });
        }

        public IEnumerable<CellPhone> GetAll()
        {
            var phones = File.ReadAllLines(RepositryFilePath);
            return phones.Select(x => JsonConvert.DeserializeObject<CellPhone>(x));
        }

        public void Remove(int id)
        {
            var phone = GetAll().Where(x => x.ID != id);
            File.Open(RepositryFilePath, FileMode.Truncate).Close();

            foreach (var phone in phones)
            {
                Add(phone);
            }
        }
    }
}
