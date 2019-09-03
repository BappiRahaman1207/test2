using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Information\n");

            Console.Write("Enter your Name: ");
            string Name=Console.ReadLine();

            Console.Write("Enter your Age: ");
            string Age = Console.ReadLine();

            Console.Write("Enter your Address: ");
            string Address = Console.ReadLine();


            Console.WriteLine("\n Information \n");

            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Address : " + Address);

            Console.ReadKey();

        }
    }
}
