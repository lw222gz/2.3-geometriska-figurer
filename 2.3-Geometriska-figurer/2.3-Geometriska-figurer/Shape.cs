using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Geometriska_figurer
{
    public abstract class Shape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                value = _length;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                value = _width;
            }
        }

        public abstract double Area
        {
            get;
        }

        public abstract double Perimeter
        {
            get;
        }


        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return string.Format("Längd:{0,9} \n Bredd:{1,9}\n Omkrets:{2,9}\n Area:{3,9}", Length, Width, Perimeter, Area);        
        }


    }
}
