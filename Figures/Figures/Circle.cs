using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius)
        {

        }
        public override double CalculateSurface()
        {
            return 3.14 * Width * Height;
        }
    }
}
