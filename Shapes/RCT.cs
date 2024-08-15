using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator.Shapes
{
    public class RCT : Shape
    {
        private double length { get; set; }
        private double width { get; set; }
        public RCT(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public  override double area()
        {
            return length * width;
        }
    }
}
