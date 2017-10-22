using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Parallelogram:Trapaezoid //平行四边形
{
    private Point p1;
    private Point p2;
    private Point p3;
    private Point p4;
    Line l1;//没写访问控制符，相当于默认protected，只能被其派生类使用
    Line l2;
    Line l3;
    Line l4;

    public Parallelogram()
    {

    }

    //用点初始化Parallelogram类的实例
    public Parallelogram(Point point1, Point point2, Point point3, Point point4)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.p4 = point4;
    }

    //用线初始化Parallelogram类的实例
    public Parallelogram(Line line1, Line line2, Line line3, Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
    }

    public override string ToString()
    {
        double a1 = p4.X - p1.X;
        double a2 = p4.Y - p1.Y;
        double b1 = p2.X - p1.X;
        double b2 = p2.Y - p1.Y;
        double c1 = p3.X - p1.X;
        double c2 = p3.Y - p1.Y;
        if (a1 + b1 == c1 && a2 + b2 == c2)
        {
            return "这是一个平行四边形";
        }
        else
        {
            return "这不是一个平行四边形，请重新输入数据";
        }
        
    }

    //返回平形四边形的周长
    public override double Perimeter()
    {
        return l1.Length() + l2.Length() + l3.Length() + l4.Length();
    }

    //返回平形四边形的面积
    public override double Area()
    {
        double p = (l1.Length() + l2.Length() + l3.Length() + l4.Length()) / 2.0;   //计算周长的一半
        double area = Math.Sqrt(p * (p - l1.Length()) * (p - l2.Length()) * (p - l3.Length()) * (p - l4.Length()));  //海伦公式计算四边形面积
        return area;
    }
}

