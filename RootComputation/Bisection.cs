using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootComputation
{
    public class Bisection : IRootCalculator
    {
        private Func<double, double> _func;

        public Bisection(Func<double, double> func)
        {
            _func = func;
        }

        /// <summary>
        /// Tries to compute a root in an intervall.
        /// </summary>
        /// <param name="a">Left intervall border.</param>
        /// <param name="b">Right intervall border.</param>
        /// <param name="epsilon"></param>
        /// <returns>The x-value of the root.</returns>
        public double ComputeRoot(double a, double b, double epsilon)
        {
            //Hier code einfügen
            throw new NotImplementedException();
        }
    }
}