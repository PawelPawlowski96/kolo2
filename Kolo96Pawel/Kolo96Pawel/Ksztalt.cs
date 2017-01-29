using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kolo96Pawel
{
    abstract class Ksztalt
    {
        protected double a;
        protected double b;
        protected double c;
        protected double d;
        public double obwod;
        public double pole;
        
        public Ksztalt(double a, double b, double c, double d) 
        {
 
        }
        public Ksztalt(double a, double b, double c) 
        {

        }
        public Ksztalt(double a, double b)
        {

        }
        public virtual double ObliczPole()
        {
            return pole;
        }
        public virtual double ObliczObwod()
        {
            return obwod;
        }
        
        
        public string  ToString() //przesłonięcie metody
        {
           return("Obwód: " + this.obwod + " ,pole: " + this.pole);
        }

    }
     
   
}
