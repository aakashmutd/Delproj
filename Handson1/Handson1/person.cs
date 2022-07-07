using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace Handson1
{
    public class person
    {
        public string name;
        public int age;
        public string city;

    }
    internal class serihandson
    {
       
       
             public void XmlSerialize()
            {  //here we will convert obj to xml type
                person per = new person();
                Console.WriteLine("Enter Name");
                per.name = Console.ReadLine();
                Console.WriteLine("Age");
                per.age =  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("City");
                per.city = Console.ReadLine();

                XmlSerializer xs = new XmlSerializer(typeof(person));  
                TextWriter txtwriter = new StreamWriter(@"C:\Users\arajendrashinde\Desktop\dot net applications\Serihandson1.xml");
                //streamwriter also usable
                xs.Serialize(txtwriter,per);
                txtwriter.Close();
            }

            public void Xmldeserialize()
            {
                person bs = new person();
                XmlSerializer xs = new XmlSerializer(typeof(person));
                StreamReader reader = new StreamReader(@"C:\Users\arajendrashinde\Desktop\dot net applications\Serihandson1.xml");
                bs = (person)xs.Deserialize(reader);  //imp: converting to emp type ; notice where reader and where writer
                Console.WriteLine("Person Details");
                Console.WriteLine("Age:" + bs.age);
                Console.WriteLine("Name:" + bs.name);
                Console.WriteLine("Subject:" + bs.city);
            }
        }
    }

