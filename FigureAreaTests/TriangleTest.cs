using FigureAreaLib;
namespace FigureAreaTests
{
    [TestClass]
    public class TriangleTest
    {       
        double a = 3;
        double b = 4;
        double c = 5;

        [TestMethod]
        public void AreaTest()
        {
            
            double expected = 6;

            Triangle triangle = new Triangle(a, b, c);
            double area = triangle.Area();
            Assert.AreEqual(expected, area);

        }
        [TestMethod]
        public void IsRightTest()
        {
            
            bool expected = true;

            Triangle triangle = new Triangle(a, b, c);
            bool isRight = triangle.IsRight();
            Assert.AreEqual(expected, isRight);


            a = 1;
            b = 2;
            c = 3;
            expected = false;

            triangle = new Triangle(a, b, c);
            isRight = triangle.IsRight();
            Assert.AreEqual(expected, isRight);


        }
    }
}