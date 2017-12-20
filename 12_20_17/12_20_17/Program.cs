using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace _12_20_17
{
    class Program
    {
        [Serializable]
        class TestClass
        {
            [JsonProperty(PropertyName = "IntegerValue")]
            public int intValue { get; set; }

            [JsonIgnore]
            public string StringValue { get; set; }
        }

        static void Main(string[] args)
        {
            TestClass t = new TestClass() { intValue = 10, StringValue = "Test" };
            JsonSerializer serializer = new JsonSerializer();
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, t);
                var result = writer.ToString();
            }
        }
    }
}
