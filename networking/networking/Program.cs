using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Class1 obj = new Class1();

            //obj.nlog();
            //Console.WriteLine(" "); question solved calling
            //Console.ReadLine();

            // SerializationDemo serialization= new SerializationDemo();
            //serialization.XmlSerialize(); this for obj to xml

            //SerializationDemo serialization = new SerializationDemo();
            //serialization.xmldeseiralize();  serialization concept 7/7/22
            //Console.Read();

            GenericsDemo gendemo = new GenericsDemo();
            //gendemo.showsalaryrep(400.20);
            //gendemo.showagerep(30);
            //gendemo.showgenderrep("Male");

            gendemo.showreport<int>(10);
            gendemo.showreport<string>("Student");
            gendemo.showreport<double>(500);
            gendemo.showreport<bool>(true);
        }
    }
}
