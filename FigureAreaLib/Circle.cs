﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area()
        {
            return Math.Round((Math.PI * Radius * Radius),2);
        }
    }
}
