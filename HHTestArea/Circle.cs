using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTestArea
{
    public class Circle : Shape
    {
        double Radius;
        public Circle(double radius)=> Radius = radius;

        public override double Area()
        {
            if(Radius > 0) return Math.Round(3.14f * Math.Pow(Radius, 2),2);
            return 0;
        }
    }
}
