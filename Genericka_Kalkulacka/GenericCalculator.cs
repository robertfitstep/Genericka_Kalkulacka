using System;
using System.Collections.Generic;
using System.Text;

namespace Genericka_Kalkulacka
{
    abstract class GenericCalculator<T>
    {
        public abstract T Add(T n1, T n2);
        public abstract T Sub(T n1, T n2);
        public abstract T Multiply(T n1, T n2);
        public abstract T Divide(T n1, T n2);
    }
}
