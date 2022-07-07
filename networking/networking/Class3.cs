using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networking
{
    internal class GenericsDemo
    {  //we reuse the logic in generics and save cdoing space
        public void showreport<T>(T value)  //generics; identify from <>
        {
            Console.WriteLine(value);
        }

        //public void showagerep(int age)
        //{
        //    Console.WriteLine(age); 
        //}

        //public void showsalaryrep(double salary)
        //{
        //    Console.WriteLine(salary);
        //}

        //public void showgenderrep(string gender)
        //{
        //    Console.WriteLine(gender);
        //}
    }
}

