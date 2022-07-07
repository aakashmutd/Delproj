using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace networking
{
    public class weatherforecast
    {
        public DateTimeOffset Date { get; set; }    
        public int Temperaturecelsius { get; set; }   
        public string Summary { get; set; } 

    }
    
    public class employee
    {
        public int id = 1;
        public string name = "John Smith";
        public string subject = "Physics";

    }
    internal class  SerializationDemo
    {
        public void Jsonserialize()
        {
            var weatherforecast = new weatherforecast()
            {
                Date = DateTime.Parse("2019-08-01"),
                Temperaturecelsius = 25,
                Summary = "Hot"
            };
            //serialize from json to object
            string jsonstring = JsonSerializer.Serialize(weatherforecast);
            //deserialize from json to object
            var obj = JsonSerializer.Deserialize<weatherforecast>(jsonstring);
            Console.WriteLine(obj.Date);
            Console.WriteLine(obj.Temperaturecelsius);
            Console.WriteLine(obj.Summary);
        }

        public void XmlSerialize()
        {  //here we will convert obj to xml type
            employee bs = new employee();
            XmlSerializer xs = new XmlSerializer(typeof(employee));  //passing employee class not object
          //typeof will map employee obj
            //use ctrl+. to see which namespace needed, then press enter to apply
            // for inbuilt classes we need this
            TextWriter txtwriter = new StreamWriter(@"C:\Users\arajendrashinde\Desktop\dot net applications\networking\Serialization.xml");
           //streamwriter also usable
            xs.Serialize(txtwriter, bs);
            txtwriter.Close();
        }

        public void xmldeseiralize()
        {
            employee bs=new employee();
            XmlSerializer xs= new XmlSerializer(typeof(employee));  
            StreamReader reader=new StreamReader(@"C:\Users\arajendrashinde\Desktop\dot net applications\networking\Serialization.xml");
            bs = (employee)xs.Deserialize(reader);  //imp: converting to emp type ; notice where reader and where writer
            Console.WriteLine("Employee Details");
            Console.WriteLine("Id:"+ bs.id);
            Console.WriteLine("Name:"+ bs.name);
            Console.WriteLine("Subject:"+ bs.subject);
        }
    }
}
