using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    struct Point3D

    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        private static readonly Point3D InitialCoordinates;
        public static Point3D StartPoint { get; } = InitialCoordinates;

        static Point3D()
        {
            InitialCoordinates = new Point3D(0, 0, 0);
        }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Coodinats: ({X}; {Y}; {Z})";
        }
    }
}
