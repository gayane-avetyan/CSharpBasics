using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[3] { new Rectangle(1, 2) , new Triangle(3, 4), new Circle(5)};
            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }
    }
}
