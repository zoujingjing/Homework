using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Quadrate:Rhombus//正方形
{
    private Point p1;
    private Point p2;
    private Point p3;
    private Point p4;
    Line l1;//没写访问控制符，相当于默认protected，只能被其派生类使用
    Line l2;
    Line l3;
    Line l4;

    //用点初始化Quadrate类的实例
    public Quadrate(Point point1, Point point2, Point point3, Point point4)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.p4 = point4;
    }

    //用线初始化Quadrate类的实例
    public Quadrate(Line line1, Line line2, Line line3, Line line4)
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
            if(l1.BCoefficient()*l2.BCoefficient() + l1.ACoefficient()*l2.ACoefficient() == 0 || l1.BCoefficient() * l3.BCoefficient() + l1.ACoefficient() * l3.ACoefficient() == 0)
            {
                return "这是一个正方形";
            }
            else
            {
                return "这不是一个正方形，请重新输入数据";
            }
            
        }
        else
        {
            return "这不是一个菱形，更不是正方形，请重新输入数据";
        }

    }

    //返回正方形的周长
    public override double Perimeter()
    {
        return l1.Length()*4;
    }

    //返回正方形的面积
    public override double Area()
    {
        double area;
        area = Math.Pow(l1.Length(), 2);  //计算正方形面积
        return area;
    }
}

