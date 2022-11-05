using System;
using System.Collections.Generic;
using System.Text;

namespace VersionControlDemo
{
    internal class Area
    {
        public double side { get; set; }
        public double area { get; set; }

        public Area(double side)
        {
            this.side = side;
        }
        public void getArea()
        {
            area = side * side;
        }
    }
}
