using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kolo96Pawel
{
    class Trojkat : Ksztalt
    {
      
        public Trojkat(double a, double b, double c) : base (a,b,c)
        {
            base.a = double.Parse(Console.ReadLine());
           base.b = double.Parse(Console.ReadLine());
            base.c = double.Parse(Console.ReadLine());
        }
        public Trojkat(double a, double b) : base (a,b)
        {

        }

        public override double ObliczObwod()
        {
            base.obwod = a + b + c;
            return obwod;
        }
        public override double ObliczPole()
        {
            base.pole = obwod/2;
            return pole;
        }
    }
}
