using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    public class GenericMaximum<T> where T:IComparable
    {
        public T[] input_Values;

        public GenericMaximum(T[] input_Values)
        {
            this.input_Values = input_Values;
        }

        public T[] Sort(T[] input_Values)
        {
            Array.Sort(input_Values);
            return input_Values;
        }

        public T getMaximum(T[] input_Values)
        {
            var sorted_Values = Sort(input_Values);
            return sorted_Values[^1];

        }
        public T MaximumValue()
        {
            var max = getMaximum(this.input_Values);
            return max;
        }
        public void printMaxValue()
        {
            var max = MaximumValue();
            Console.WriteLine("Maximum values is :" + max);
        }
    }
}
