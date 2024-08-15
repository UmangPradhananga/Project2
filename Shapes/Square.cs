using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator.Shapes
{
    public class Square : Shape
    {
        private double length { get; set; }
        public Square(double length)
        {
            this.length = length;
        }

        public override double area()
        {
            return length * length;
        }

    }
}
