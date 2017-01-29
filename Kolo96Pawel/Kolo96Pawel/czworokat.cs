using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo96Pawel
{
    class czworokat : Ksztalt
    {
        czworokat(double a, double b, double c, double d) : base(a, b, c, d) 
        {
            base.a = double.Parse(Console.ReadLine());
            base.b = double.Parse(Console.ReadLine());
            base.c = double.Parse(Console.ReadLine());
            base.d = double.Parse(Console.ReadLine());
        }
       
        public override double ObliczObwod()
        {
            base.obwod = a + b + c +d;
            return obwod;
        }
        public override double ObliczPole()
        {
            base.pole = a + b + c + d;
            return pole;
        }
       
    }
}
