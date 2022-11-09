using FigureArea;

var circle = new Circle(10);
Console.WriteLine(circle.Area());

var triangle = new Triangle(3, 4, 5);
Console.WriteLine(triangle.Area());

Console.WriteLine(triangle.IsRight());

var trianle1 = new Triangle(1, 2, 3);
Console.WriteLine(trianle1.IsRight());
