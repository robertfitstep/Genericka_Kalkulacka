using System;
using System.Collections.Generic;
using System.Text;

namespace Genericka_Kalkulacka
{
    class FloatCalculator<T> : GenericCalculator<T>
    {
        public FloatCalculator()
        {
            if (typeof(T) != typeof(float)) throw new Exception("Invalid data type.");
        }

        public override T Add(T n1, T n2)
        {
            float result = (float)Convert.ToDouble(n1) + (float) Convert.ToDouble(n2);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public override T Sub(T n1, T n2)
        {
            float result = (float) Convert.ToDouble(n1) - (float) Convert.ToDouble(n2);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public override T Multiply(T n1, T n2)
        {
            float result = (float) Convert.ToDouble(n1) * (float) Convert.ToDouble(n2);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public override T Divide(T n1, T n2)
        {
            float result = (float) Convert.ToDouble(n1) / (float) Convert.ToDouble(n2);
            return (T)Convert.ChangeType(result, typeof(T));
        }
    }
}
