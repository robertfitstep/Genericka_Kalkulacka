using System;
using System.Collections;

namespace Genericka_Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            IntCalculator<int> IntCalc = new IntCalculator<int>();
            FloatCalculator<float> FloatCalc = new FloatCalculator<float>();

            int i1 = 10;
            int i2 = 2;

            Console.WriteLine("Addition: {0} + {1} = {2}",i1,i2,IntCalc.Add(i1,i2));
            Console.WriteLine("Subtraction: {0} - {1} = {2}", i1, i2, IntCalc.Sub(i1, i2));
            Console.WriteLine("Multiplication: {0} * {1} = {2}", i1, i2, IntCalc.Multiply(i1, i2));
            Console.WriteLine("Division: {0} / {1} = {2}", i1, i2, IntCalc.Divide(i1, i2));

            float f1 = 10.2f;
            float f2 = 2.4f;

            Console.WriteLine("Addition: {0} + {1} = {2}", f1, f2, FloatCalc.Add(f1, f2));
            Console.WriteLine("Subtraction: {0} - {1} = {2}", f1, f2, FloatCalc.Sub(f1, f2));
            Console.WriteLine("Multiplication: {0} * {1} = {2}", f1, f2, FloatCalc.Multiply(f1, f2));
            Console.WriteLine("Division: {0} / {1} = {2}", f1, f2, FloatCalc.Divide(f1, f2));

            Console.ReadKey();
        }
    }
}
