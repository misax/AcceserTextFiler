using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AcceserTextFiler
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\admin\Test4.txt";
            List<Person> p = new List<Person>();
            List<string> outputer = new List<string>();
            outputer.CreatePeople(p,filePath);
            p.Add(new Person(){First = "Boda",Last = "Tolda",URL = "www.troldak.inline"});
        
          
           
           var output =  outputer.WriteInfosToFile(p,filePath);
           Console.WriteLine(output);
            //string text = "something difficult";
            // lines = ReadLines(filePath);
            //Foreach(lines);
            //Add(lines,text);
            //File.WriteAllLines(filePath, lines);

            Console.ReadLine();
        }
    }
}
