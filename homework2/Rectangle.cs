using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Rectangle:Parallelogram//长方形
{
    private Point p1;
    private Point p2;
    private Point p3;
    private Point p4;
    Line l1;//没写访问控制符，相当于默认protected，只能被其派生类使用
    Line l2;
    Line l3;
    Line l4;

    public Rectangle()
    {

    }

    //用点初始化Rectangle类的实例
    public Rectangle(Point point1, Point point2, Point point3, Point point4)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
        this.p4 = point4;
    }

    //用线初始化Rectangle类的实例
    public Rectangle(Line line1, Line line2, Line line3, Line line4)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
        this.l4 = line4;
    }

    public override string ToString()
    {
        if (l1.ACoefficient() == l2.ACoefficient() || l1.ACoefficient() == l3.ACoefficient()) 
        {
            if(l1.BCoefficient() * l2.BCoefficient() + l1.ACoefficient() * l2.ACoefficient() == 0 || l1.BCoefficient() * l3.BCoefficient() + l1.ACoefficient() * l3.ACoefficient() == 0)
            {
                return "这是一个长方形";
            }
            else
            {
                return "这不是一个长方形，请重新输入数据";
            }
            
        }
        else
        {
            return "这不是一个平行四边形，更不是一个长方形，请重新输入数据";
        }

    }

    //返回长方形的周长
    public override double Perimeter()
    {
        if(l1.Length() == l2.Length())
        {
            return 2*(l1.Length() + l3.Length());
        }
        else
        {
            return 2 * (l1.Length() + l2.Length());
        }
        
    }

    //返回长方形的面积
    public override double Area()
    {
        if (l1.Length() == l2.Length())
        {
            return l1.Length() * l3.Length();
        }
        else
        {
            return l1.Length() * l2.Length();
        }
    }

}

