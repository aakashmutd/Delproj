using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Handson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            serihandson seria= new serihandson();
          //  seria.XmlSerialize(); //this for obj to xml
            
          // seria.Xmldeserialize(); 
           json js= new json();
            js.Jsonserialize();
            
            Console.Read();
        }
    }
}
