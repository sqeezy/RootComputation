using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RootComputation
{
    public interface IRootCalculator
    {
        /// <summary>
        /// Tries to compute a root in an intervall.
        /// </summary>
        /// <param name="a">Left intervall border.</param>
        /// <param name="b">Right intervall border.</param>
        /// <param name="epsilon"></param>
        /// <returns>The x-value of the root.</returns>
        double ComputeRoot(double a, double b, double epsilon);
    }
}