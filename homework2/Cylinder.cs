using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cylinder:Circle//圆柱体
{
    private Circle circle;
    private double high;

    public Circle C1
    {
        get { return this.circle; }
        set { this.circle = value; }
    }

    public double H1
    {
        get { return this.high; }
        set { this.high = value; }
    }

    //初始化Cylinder类的实例
    public Cylinder(Circle circle1, double high1)
    {
        this.circle = circle1;
        this.high = high1;
        
    }

    public override string ToString()
    {
        return "这是一个圆柱体";
    }

    //返回圆柱体的面积
    public override double Area()
    {
        double area;
        area = 2 * circle.Area() + high * circle.Perimeter();
        return area;
    }

    //返回圆柱体的体积
    public override double Volume()
    {
        double volume;
        volume = circle.Area() * high;
        return volume;
    }
}

