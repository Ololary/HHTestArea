using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTestArea
{
    public class Trungle : Shape
    {
        double sideA;
        double sideB;
        double sideC;
        public Trungle(double sideA, double sideB, double sideC)
        {
            if (isTrungle(sideA,sideB,sideC))
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            
        }

        public override double Area()
        {
            double p = (sideA + sideB + sideC)/2;
            return Math.Sqrt(p*(p - sideA)*(p - sideB)*(p - sideC));
        }

        public bool isTrungle(double a, double b, double c) 
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ShapeException("Сторона(ы) треугольника не могут быть равны 0");
            }

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new ShapeException("Сторона треугольника не можнт быть больше суммы двух других!");
            }

            return true;
        }
        public bool isTrungleStright(double a, double b, double c) =>
        
            a > (b + c)||b>(a+b) || c > (a+c);
        
       
    }
}
