using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TestMain
{
    public static void Main(string[] args)
    {
        double perimeter;  //周长
        double area;       //面积
        double volume;     //体积

        //圆类
        Circle circle = new Circle(37, 43, 2.5);

        Console.WriteLine(circle.ToString());
        perimeter = circle.CircumFerence();
        area = circle.Area();
        Console.WriteLine("该圆的周长是:{0}", perimeter);
        Console.WriteLine("该圆的面积是:{0}", area);
        circle.X = 20;
        circle.Y = 20;

        Console.WriteLine("该圆的新圆心坐标是:{0},{1}", circle.X, circle.Y);
        Console.WriteLine();

        //圆柱体
        double high = 10;
        Cylinder cylinder = new Cylinder(circle,high);
        Console.WriteLine(cylinder.ToString()); 
        area = cylinder.Area();
        volume = cylinder.Volume();
        Console.WriteLine("该圆柱体的面积是:{0}", area);
        Console.WriteLine("该圆柱体的体积是:{0}", volume);
        Console.WriteLine();

        //三角形
        Point point1 = new Point(1, 1);
        Point point2 = new Point(4, 5);
        Point point3 = new Point(3, 8);
        Line line1 = new Line(point1,point2);
        Line line2 = new Line(point2, point3);
        Line line3 = new Line(point1, point3);
        Triangle triangle1 = new Triangle(point1,point2,point3);
        Console.WriteLine(triangle1.ToString());
        Triangle triangle2 = new Triangle(line1, line2, line3);
        perimeter = triangle2.Perimeter();
        area = triangle2.Area();
        Console.WriteLine("该三角形的周长是:{0}", perimeter);
        Console.WriteLine("该三角形的面积是:{0}", area);
        if (triangle2.IsEquicrural())
        {
            Console.WriteLine("该三角形是一个等腰三角形。");
            if (triangle2.IsEquilateral())
            {
                Console.WriteLine("该三角形是一个等边三角形。");
            }
        }
        else
        {
            Console.WriteLine("该三角形不是等腰三角形。");
        }
        Console.WriteLine();

        //四边形
        Point point4 = new Point(7,3);
        Line line4 = new Line(point1, point4);
        Line line5 = new Line(point3, point4);
        Quadrilateral quadrilateral1 = new Quadrilateral(point1, point2, point3, point4);
        Console.WriteLine(quadrilateral1.ToString());
        Quadrilateral quadrilateral2 = new Quadrilateral(line1, line2, line4, line5);
        perimeter = quadrilateral2.Perimeter();
        area = quadrilateral2.Area();
        Console.WriteLine("该四边形的周长是:{0}", perimeter);
        Console.WriteLine("该四边形的面积是:{0}", area);
        Console.WriteLine();

        //梯形
        Point point5 = new Point(2, 1);
        Point point6 = new Point(9, 1);
        Point point7 = new Point(7, 4);
        Point point8 = new Point(4, 4);
        Line line6 = new Line(point5, point6);
        Line line7 = new Line(point6, point7);
        Line line8 = new Line(point7, point8);
        Line line9 = new Line(point8, point5);
        Trapaezoid trapaezoid1 = new Trapaezoid(point5, point6, point7, point8);
        Trapaezoid trapaezoid2 = new Trapaezoid(line6, line7, line8, line9);
        Console.WriteLine(trapaezoid2.ToString());
        perimeter = trapaezoid2.Perimeter();
        area = trapaezoid2.Area();
        Console.WriteLine("该梯形的周长是:{0}", perimeter);
        Console.WriteLine("该梯形的面积是:{0}", area);
        if (trapaezoid2.IsIsosceles())
        {
            Console.WriteLine("这是一个等腰梯形。");
        }
        Console.WriteLine();

        //平行四边形
        Parallelogram parallelogram1 = new Parallelogram(point1, point2, point3, point4);
        Console.WriteLine(parallelogram1.ToString());
        Point point9 = new Point(5, 2);
        Point point10 = new Point(7, 5);
        Line line10 = new Line(point5, point9);
        Line line11 = new Line(point9, point10);
        Line line12 = new Line(point10, point8);
        Parallelogram parallelogram2 = new Parallelogram(point5, point9, point10, point8);
        Console.WriteLine(parallelogram2.ToString());
        Parallelogram parallelogram3 = new Parallelogram(line10,line11,line12,line9);
        perimeter = parallelogram3.Perimeter();
        area = parallelogram3.Area();
        Console.WriteLine("该平形四边形的周长是:{0}", perimeter);
        Console.WriteLine("该平行四边形的面积是:{0}", area);
        Console.WriteLine();

        //长方形
        Rectangle rectangle1 = new Rectangle(line10, line11, line12, line9);
        Console.WriteLine(rectangle1.ToString());
        Point point13 = new Point(1, 5);
        Point point14 = new Point(9, 5);
        Line line13 = new Line(point1, point6);
        Line line14 = new Line(point6, point14);
        Line line15 = new Line(point14, point13);
        Line line16 = new Line(point13, point1);
        Rectangle rectangle2 = new Rectangle(line13, line14, line15, line16);
        Console.WriteLine(rectangle2.ToString());
        perimeter = rectangle2.Perimeter();
        area = rectangle2.Area();
        Console.WriteLine("该长方形的周长是:{0}", perimeter);
        Console.WriteLine("该长方形的面积是:{0}", area);
        Console.WriteLine();

        //菱形
        Point point15 = new Point(7, 6);
        Point point16 = new Point(4, 8);
        Point point17 = new Point(1, 6);
        Line line17 = new Line(point8, point15);
        Line line18 = new Line(point15, point16);
        Line line19 = new Line(point16, point17);
        Line line20 = new Line(point17, point8);
        Rhombus rhombus = new Rhombus(line17, line18, line19, line20);
        Console.WriteLine(rhombus.ToString());
        perimeter = rhombus.Perimeter();
        area = rhombus.Area();
        Console.WriteLine("该菱形的周长是:{0}", perimeter);
        Console.WriteLine("该菱形的面积是:{0}", area);
        Console.WriteLine();

        //正方形
        Point point18 = new Point(2, 6);
        Point point19 = new Point(6, 6);
        Line line21 = new Line(point8, point19);
        Line line22 = new Line(point19, point16);
        Line line23 = new Line(point16, point18);
        Line line24 = new Line(point18, point8);
        Quadrate quadrate = new Quadrate(line21, line22, line23, line24);
        Console.WriteLine(quadrate.ToString());
        perimeter = quadrate.Perimeter();
        area = quadrate.Area();
        Console.WriteLine("该正方形的周长是:{0}", perimeter);
        Console.WriteLine("该正方形的面积是:{0}", area);
        Console.WriteLine();


    }
}
