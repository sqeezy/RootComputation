using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RootComputation
{
    public class RegulaFalsi : IRootCalculator
    {
        public enum CalculationType
        {
            Recursive,
            Iterativ
        }

        private Func<double, double> _func;

        private CalculationType _type;

        public RegulaFalsi(Func<double, double> func) : this(func, CalculationType.Recursive)
        {
        }

        public RegulaFalsi(Func<double, double> func, CalculationType type)
        {
            _func = func;
            _type = type;
        }

        public double ComputeRoot(double a, double b, double epsilon)
        {
            switch (_type)
            {
                case CalculationType.Iterativ:
                    return SolveIterativ(a, b, epsilon);

                case CalculationType.Recursive:
                    return SolveRekursiv(a, b, epsilon);
                default:
                    return SolveIterativ(a, b, epsilon);
            }
        }

        private double SolveIterativ(double a, double b, double epsilon)
        {
            double ay = _func(a);
            double by = _func(b);
            if (Math.Abs(ay) <= epsilon)
            {
                return a;
            }
            if (Math.Abs(by) <= epsilon)
            {
                return b;
            }
            if (ay < 0 && by < 0 || ay > 0 && by > 0)
            {
                throw new ArgumentException("Die Funktionswerte von a und b haben das gleiche Vorzeichen, Idiot!");
            }

            double c = 1.0e10;

            while (Math.Abs(_func(c)) > epsilon)
            {
                c = (a*_func(b) - b*_func(a))/(_func(b) - _func(a));

                if (_func(c) < 0)
                {
                    if (_func(a) < 0)
                    {
                        a = c;
                    }
                    if (_func(b) < 0)
                    {
                        b = c;
                    }
                }
                if (_func(c) > 0)
                {
                    if (_func(a) > 0)
                    {
                        a = c;
                    }
                    if (_func(b) > 0)
                    {
                        b = c;
                    }
                }
            }

            return Math.Round(c, 3);
        }

        private double SolveRekursiv(double a, double b, double epsilon)
        {
            double ay = _func(a);
            double by = _func(b);
            if (Math.Abs(ay) <= epsilon)
            {
                return a;
            }
            if (Math.Abs(by) <= epsilon)
            {
                return b;
            }
            if (ay < 0 && by < 0 || ay > 0 && by > 0)
            {
                throw new ArgumentException("Die Funktionswerte von a und b haben das gleiche Vorzeichen, Idiot!");
            }

            double c = (a*_func(b) - b*_func(a))/(_func(b) - _func(a));

            if (_func(c) < 0)
            {
                if (_func(a) < 0)
                {
                    a = c;
                }
                if (_func(b) < 0)
                {
                    b = c;
                }
            }
            if (_func(c) > 0)
            {
                if (_func(a) > 0)
                {
                    a = c;
                }
                if (_func(b) > 0)
                {
                    b = c;
                }
            }
            return SolveRekursiv(a, b, epsilon);
        }
    }
}