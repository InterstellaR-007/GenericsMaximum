using System;
using System.ComponentModel.DataAnnotations;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            string[] stringArray = { "1.22","2.54","10.2222" };

            GenericMaximum<int> getMaximumInteger = new GenericMaximum<int>(intArray);
            getMaximumInteger.printMaxValue();

            GenericMaximum<string> getMaximumString = new GenericMaximum<string>(stringArray);
            getMaximumString.printMaxValue();

            GenericMaximum<double> getMaximumDouble = new GenericMaximum<double>(doubleArray);
            getMaximumDouble.printMaxValue();

        }
        
        
    }
}
