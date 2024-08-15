using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator
{
    public abstract class Shape
    {
        public abstract double area();
        public void Message (string shape) 
        {
            Console.WriteLine($"Area of the given {shape} ={area()} " );
        }
        //public bool con()
        //{
        //    Console.WriteLine(" Do you want to continue?(yes/no)");
        //    string con = Console.ReadLine().ToLower();
        //    switch (con)
        //    {
        //        case "yes":
        //            return true;
        //        case "no":
        //            return false;
        //        default:
        //            return true;
        //    }
        //}
  
    }
}
