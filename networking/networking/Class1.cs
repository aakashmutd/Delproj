using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace networking
{
    internal class Class1
    {
        public void nlog()
        {

            FileStream fileStream = new FileStream(@"C:\Users\arajendrashinde\Desktop\dot net applications\networking\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamreaderobj = new StreamReader(fileStream);
            Console.WriteLine("ID\tSource\t\tDestination\tDate\t\t\tStatus\tNetwork");

           
             string[] a = new string[10];
            
            
            while (streamreaderobj.Peek() > 0)
            {  
                string line = streamreaderobj.ReadLine();

                if(line.StartsWith("Id:"))
                { a = line.Split(':');

                    Console.Write(a[1] + "\t");
                        }
              else  if (line.StartsWith("Source:"))
                {
                    a = line.Split(':');

                    Console.Write(a[1] + "\t");
                }
                else if (line.StartsWith("Destination:"))
                {
                    a = line.Split(':');

                    Console.Write(a[1] + "\t");
                }
                else if (line.StartsWith("Date:"))
                {
                    a = line.Split(':');

                    Console.Write(a[1] + ":" + a[2] + ":" + a[3] + "\t");
                }
                else if (line.StartsWith("Status:"))
                {
                    a = line.Split(':');
                  
                    Console.Write(a[1] + "\t");

                }
                else if (line.StartsWith("Network:"))
                {
                    a = line.Split(':');

                    Console.Write(a[1]+"\t");
                }
                else
                { Console.WriteLine(""); }

            }



            fileStream.Close();

        }
    }
}

