using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Geometriska_figurer
{
    public class Rectangle : Shape
    {
        public override double Area
        {
            get { return Width * Length; }
        }

        public override double Perimeter
        {
            get { return (Width * 2) + (Length * 2); }
        }

        public Rectangle(double length, double width) : base(length, width)
        {
        }
    }
}
