using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public sealed class Triangle:Shape //Triangle类，包含三个Point，采用sealed,表示是继承树的根类
{
    private Point p1;
    private Point p2;
    private Point p3;
    Line l1;//没写访问控制符，相当于默认protected，只能被其派生类使用
    Line l2;
    Line l3;

    public Point P1
    {
        get { return this.p1; }
        set { this.p1 = value; }
    }

    public Point P2
    {
        get { return this.p2; }
        set { this.p2 = value; }
    }

    public Point P3
    {
        get { return this.p3; }
        set { this.p3 = value; }
    }
   

    //用点初始化Triangle类的实例
    public Triangle(Point point1, Point point2, Point point3)
    {
        this.p1 = point1;
        this.p2 = point2;
        this.p3 = point3;
    }

    //用线初始化Triangle类的实例
    public Triangle(Line line1, Line line2, Line line3)
    {
        this.l1 = line1;
        this.l2 = line2;
        this.l3 = line3;
    }

    //返回三角形的周长
    public override double Perimeter()
    {
       return l1.Length() + l2.Length() + l3.Length();
    }

    //返回三角形的面积
    public override double Area() 
    {
        double p;
        double area;
        p = (l1.Length() + l2.Length() + l3.Length()) / 2.0;   //计算周长的一半
        area = Math.Sqrt(p * (p - l1.Length()) * (p - l2.Length()) * (p - l3.Length()));  //海伦公式计算三角形面积
        return area;
    }

    public bool IsEquicrural()//判断是否为等腰三角形
    {
        if(l1.Length() == l2.Length() || l2.Length() == l3.Length() || l1.Length() == l3.Length())   //判断是否存在两条边相等 
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsEquilateral()//判断是否为等边三角形
    {
        if(l1.Length() == l2.Length() && l2.Length() == l3.Length() && l1.Length() == l3.Length())   //判断三边是否都相等
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public override string ToString()
    {
        return "这是一个三角形";
    }

}