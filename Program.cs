
using Area_Calculator;
using Area_Calculator.Shapes;
using System.Diagnostics;
using System.Drawing;
public class Program
{
    public static void Main(string[] args)
    {

        bool counter = true;
        //Console.WriteLine("How many shapes do you want to calculate");
        //int count = Convert.ToInt32(Console.ReadLine());
        //for (int j = 0; j < count; j++)
        //{
            while (counter) 
            { 
                Console.WriteLine("What Do Shape you want to calculate(cricle,square,reactangle and triangle)");
                string[] shapes = Console.ReadLine().Split(',');
                foreach(string shape in shapes)
                {
                    switch (shape)
                    {
                        case "rectangle":
                            Console.WriteLine("Can You Please Provide me Length");
                            double length_rec = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Can You Please Provide me Width");
                            double width_rec = Convert.ToInt32(Console.ReadLine());

                            Shape react_Shape = new RCT(length_rec, width_rec);
                            react_Shape.area();
                            react_Shape.Message("Rectangle");
                            
                            break;

                        case "square":
                            Console.WriteLine("Can You Please Provide me Length");
                            double length_square = Convert.ToDouble(Console.ReadLine());
                            Shape square_shape = new Square(length_square);
                            square_shape.area();
                            square_shape.Message("Square");
                            break;

                        case "triangle":
                            Console.WriteLine("Can You Please Provide me base");
                            double base_tri = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Can You Please Provide me height");
                            double height_tri = Convert.ToDouble(Console.ReadLine());

                            Shape triangle_Shape = new Triangle(base_tri, height_tri);
                            triangle_Shape.area();
                            triangle_Shape.Message("Triangle");
                            break;

                        case "circle":
                            Console.WriteLine("Can You Please Provide me radius");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Shape cricle_Shape = new Circle(radius);
                            cricle_Shape.area();
                            cricle_Shape.Message("Circle");
                            break;

                        default:
                            Console.WriteLine("Error");
                            Console.WriteLine("Press any key to restart");
                            Console.ReadKey(true);
                            counter = true;
                            continue;

                    }
                    counter= false; 
                }
            }
            
            
        
    }
}