using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//return tyoe methods-int,string,float,decimal,object
// no return type method- void
namespace c_sharp_application
{
    public class Event
    {
        public int EventId;
        public string CreateEvent()
        {
            Console.WriteLine("Event Created");
            return "10";        }
        public void SelectEvents()
        {
            Console.WriteLine("Events scheduled");

        }
    }


}
