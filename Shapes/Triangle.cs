using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator.Shapes
{
    public class Triangle : Shape
    {
        private double b { get; set; }
        private double h {  get; set; }
        public Triangle(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public override double area()
        {
            double area = (0.5) * b * h;
            return area;


        }
    }
}
