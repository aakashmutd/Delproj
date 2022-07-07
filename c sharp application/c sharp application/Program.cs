using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_application
{
    internal class Program
    {
        static void Main(string[] args)
        {  /*
            int a;
            int b;
            int c;
            Console.WriteLine("Enter A value");

            a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter B value");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            // how to print/display output?
            Console.WriteLine(c);
            Console.Read(); //how to read keyboard input ? */
            //for (int j = 0; j <=5; j++)
            //{
            //    Console.WriteLine(j);
            //}
            /*
            Customer customerobj= new Customer();
            string opcust = customerobj.CreateCustomer();
            Console.WriteLine(opcust);
            customerobj.SelectCustomer();

            Event eventobj = new Event(); //creating instance of class i.e. object
            string output = eventobj.CreateEvent();
            Console.WriteLine(output);
            eventobj.SelectEvents();

            booking bookingobj = new booking();
            string opbooking=bookingobj.Createbooking();
            Console.WriteLine(opbooking);
            bookingobj.Selectbooking();
            Console.Read(); */

            movie movieobj = new movie();
            //  movieobj.CreateMovie();
            movieobj.SelectMovie();
            Console.WriteLine("Program Executed");
            Console.ReadLine();
        } 
    }
}
