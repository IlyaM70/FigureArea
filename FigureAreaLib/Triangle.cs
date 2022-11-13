using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib
{
    public class Triangle : IFigure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            var p = (a + b + c) / 2;
            return Math.Round((Math.Sqrt(p * (p - a) * (p - b) * (p - c))),2);
        }

        public bool IsRight()
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
            {
                return true;
            }
            else return false;
        }
    }
}
