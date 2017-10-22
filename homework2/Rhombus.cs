using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rhombus:Parallelogram//菱形
{
    private Point p1;
    private Point p2;
    private Point p3;
    private Point p4;
    Line l1;//没写访问控制符，相当于默认protected，只能被其派生类使用
    Line l2;
    Line l3;
    Line l4;

    public Rhombus()
    {

    }

    //用点初始化Rhombus类的实例
    public Rhombus(Point point1, Point point2, Point point3, Point point4)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.p4 = point4;
    }

    //用线初始化Rhombus类的实例
    public Rhombus(Line line1, Line line2, Line line3, Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
    }
   
    public override string ToString()
    {
        if (l1.Length() == l2.Length() && l2.Length() == l3.Length() && l3.Length() == l4.Length())
        {
            return "这是一个菱形";
        }
        else
        {
            return "这不是一个菱形，请重新输入数据";
        }

    }

    //返回菱形的周长
    public override double Perimeter()
    {
        return l1.Length() + l2.Length() + l3.Length() + l4.Length();
    }

    //返回菱形的面积
    public override double Area()
    {
        double p = (l1.Length() + l2.Length() + l3.Length() + l4.Length()) / 2.0;   //计算周长的一半
        double area = Math.Sqrt(p * (p - l1.Length()) * (p - l2.Length()) * (p - l3.Length()) * (p - l4.Length()));  //海伦公式计算四边形面积
        return area;
    }
}
