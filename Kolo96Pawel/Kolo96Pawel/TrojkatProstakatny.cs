using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kolo96Pawel
{
    class TrojkatProstakatny : Trojkat
    {
     
        TrojkatProstakatny(double a, double b, double c, double pomocna) : base(a, b,c)
        {
           
            base.a = double.Parse(Console.ReadLine());
            base.b = double.Parse(Console.ReadLine());
            this.c = a * a + b * b;;
          
        }
      
     
    }
}
