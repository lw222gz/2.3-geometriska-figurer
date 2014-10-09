﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Geometriska_figurer
{
    public class Ellipse : Shape
    {
        
        public override double Area
        {
            get { return Math.PI * (Length / 2) * (Width / 2); }
        }

        public override double Perimeter
        {
            get { return Math.PI * Math.Sqrt(2*((Length/2)*(Length/2)) + 2*((Width/2)*(Width/2))); }
        }

        public Ellipse(double length, double width) :base(length, width)
        {
        }

    }
}
