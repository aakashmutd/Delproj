using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//for file handling compulsory

namespace c_sharp_application
{
    internal class movie
    { public void CreateMovie()
        {
            //step 1 how to create file ?
            FileStream fileStreamobj = new FileStream("C:\\Users\\arajendrashinde\\Desktop\\dot net applications\\movie.txt", FileMode.Create, FileAccess.Write);
            // instead of \\ we can do @""     

            //how to write file
            StreamWriter streamWriter = new StreamWriter(fileStreamobj);
            string movieid;
            string moviename, moviedesc, movielanguage;

            Console.WriteLine("Enter Movie ID");
            //  movieid = Convert.ToInt32(Console.ReadLine());
            movieid = Console.ReadLine();
            Console.WriteLine("Enter Movie name");
            moviename = Console.ReadLine();
            Console.WriteLine("Enter Movie Description");
            moviedesc = Console.ReadLine();
            Console.WriteLine("Enter Movie Language");
            movielanguage = Console.ReadLine();



            streamWriter.WriteLine(movieid);
            streamWriter.WriteLine(moviename);
            streamWriter.WriteLine(moviedesc);
            streamWriter.WriteLine(movielanguage);
            streamWriter.Close(); //streamwriter closed
            fileStreamobj.Close(); //file stream closed
            Console.WriteLine("File operation completed");
            Console.ReadLine();

        }
    

    public void SelectMovie()
        {

        FileStream fileStream = new FileStream(@"C:\Users\arajendrashinde\Desktop\dot net applications\movie.txt", FileMode.Open, FileAccess.Read);
        StreamReader streamreaderobj = new StreamReader(fileStream);
            //Console.WriteLine(streamreaderobj.ReadLine());
            //Console.WriteLine(streamreaderobj.ReadLine());
            //Console.WriteLine(streamreaderobj.ReadLine());
            //Console.WriteLine(streamreaderobj.ReadLine());  // for each seperate line we use this

            //while(streamreaderobj.Peek()> 0) //for line by line
            //{
            //    Console.WriteLine(streamreaderobj.ReadLine());
            //}

            // Console.WriteLine(streamreaderobj.ReadToEnd()); //for all lines i.e. read all data from file

            //split concept, reading part of a string
            //fixed array and dynamic array
            string[] myvalues= new string[5];
            myvalues[0] = "A";
            while (streamreaderobj.Peek() > 0)
            {
                string line = streamreaderobj.ReadLine();
               
                string[] mystr=line.Split(':');
                Console.WriteLine(mystr[2]);
            }                                   //    Console.WriteLine(streamreaderobj.ReadLine());

                fileStream.Close();

       }
    }

}
