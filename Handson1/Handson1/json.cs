using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Handson1
{
    public class person1
    {
        public int age { get; set; }
        public string name { get; set; }
        public string city { get; set; }

    }
    internal class json
    {
        public void Jsonserialize()
        {
            var person1 = new person1()
            {
                age = Convert.ToInt32(Console.ReadLine()),
                name=Console.ReadLine(),
                city=Console.ReadLine(),
            };
            //serialize from json to object
            string jsonstring = JsonSerializer.Serialize(person1);
            //deserialize from json to object
            var obj = JsonSerializer.Deserialize<person1>(jsonstring);
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.city);
        }
    }
}
