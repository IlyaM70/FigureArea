using FigureAreaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaTests
{
    [TestClass]
    public class CircleTest
    {
        double radius = 10;
        [TestMethod]
        public void AreaTest()
        {
            double expected = 314.16;

            Circle circle = new Circle(radius);
            double area = circle.Area();
            Assert.AreEqual(expected, area);
        }
    }
}
