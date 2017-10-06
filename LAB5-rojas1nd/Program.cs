using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_rojas1nd
{
    class Program
    {

        /// <summary>
        /// Program that shows you the BMI of a Perosn. 
        /// </summary>
        /// <param name="args">Main Method that creates a person and checks the BMI of that Person</param>
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Fname = "john";
            p.Lname = "doe";
            p.Age = 23;
            p.Weight = 63;
            p.Height = 1.67;

            p.Print();
            
            Console.Read();

            

        }
    }
}
