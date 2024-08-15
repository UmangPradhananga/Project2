using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator.Shapes
{
    public class Circle : Shape
    {
        double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double area()
        {
            double area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
