using System;
using System.Collections.Generic;
using System.Text;

namespace Genericka_Kalkulacka
{
    class IntCalculator<T> : GenericCalculator<T>
    {
        public IntCalculator()
        {
            if (typeof(T) != typeof(int)) throw new Exception("Invalid data type.");
        }

        public override T Add(T n1, T n2)
        {
            int result = Convert.ToInt32(n1) + Convert.ToInt32(n2);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public override T Sub(T n1, T n2)
        {
            int result = Convert.ToInt32(n1) - Convert.ToInt32(n2);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public override T Multiply(T n1, T n2)
        {
            int result = Convert.ToInt32(n1) * Convert.ToInt32(n2);
            return (T)Convert.ChangeType(result, typeof(T));
        }

        public override T Divide(T n1, T n2)
        {
            int result = Convert.ToInt32(n1) / Convert.ToInt32(n2);
            return (T)Convert.ChangeType(result, typeof(T));
        }  
    }
}
