using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class ArithmeticSequence
    {
        double _start;
        double _increment;

        public ArithmeticSequence() : this(0, 1) { }

        public ArithmeticSequence(double start, double increment)
        {
            _start = start;
            _increment = increment;
        }

        public double this[int index]
        {
            get
            {
                return (_start + (index - 1) * _increment);
            }
        }

        public double GetSum(int n)
        {
            return (this[1] + this[n]) / 2 * n;
        }

        public override string ToString()
        {
            return $"a[1] = {_start}, d = {_increment}";
        }
    }
}
