using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiLoffsFormula1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            task1();
                                   
        }

        //public double RandomVar()
        //{
        //    Random x = new Random();
        //    double a = Convert.ToDouble(x.Next(100));
        //    double b = Convert.ToDouble(x.Next(100));
        //    double c = Convert.ToDouble(x.Next(100));
        //    double d = Convert.ToDouble(x.Next(100));
        //    return;
        //}

        public static void task1()
        {
            double a , b, c, d;
            //RandomVar(a,b,c);
            Random x = new Random();
            a = Convert.ToDouble(x.Next(100));
            b = Convert.ToDouble(x.Next(100));
            c = Convert.ToDouble(x.Next(100));

            d = (b + Math.Sqrt(b * b + 4 * a * c)) / 2 * a - Math.Pow(a, 3) * c + Math.Pow(b, -2);
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            Console.WriteLine("d = " + d);
        }


    }
}
