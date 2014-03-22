using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootComputation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Func<double, double> func = (x) => x*x*Math.Sin(x) - 2*x*Math.Sin(x) - 8*Math.Sin(x);
            RegulaFalsi reg = new RegulaFalsi(func);
            Console.WriteLine(reg.ComputeRoot(-4, 0.5, 1.0e-50));
            Console.ReadKey();
        }
    }
}