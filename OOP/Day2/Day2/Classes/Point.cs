using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Classes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int _x,int _y)
        {
            X = _x;
            Y = _y;
        }
    }


    public class Circle : Point
    {
        public Circle(int X,int Y) : base(X,Y)
        {

        }

        public double RadiusCircle()
        {
            return X / 2;
        }

        public double AreaCircle()
        {
            return 3.14159 * Math.Pow(RadiusCircle(), 2);
        }
    }

    public class Cylinder : Circle
    {
        public double Hight { get; set; }
        public Cylinder(int X, int Y,double _hight) : base(X, Y)
        {
            Hight = _hight;
        }

        public double AreaCylinder()
        {
            return 3.14159 * Math.Pow(RadiusCircle(), 2)*Hight;
        }
    }
}
