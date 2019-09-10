using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayElements
{
    public class MinElements
    {
        public static double SummMinimumElementOfArray(double[] array)
        {
            if (array.Length == 0)
                throw new NullReferenceException();
            if (array.Length == 1)
                return array[0];
            return OneRunForArray(array);
        }

        static double OneRunForArray(double[] array)
        {
            int minIndex1, minIndex2;
            if (array[0]<array[1])
            {
                minIndex1 = 0;
                minIndex2 = 1;
            }
            else
            {
                minIndex1 = 1;
                minIndex2 = 0;
            }
            for (int i=2;i<array.Length;i++)
            {
                if (array[i] < array[minIndex1])
                {
                    var buff = minIndex1;
                    minIndex1 = i;
                    if (array[buff] < array[minIndex2])
                        minIndex2 = buff;
                }
                else if (array[i] < array[minIndex2])
                    minIndex2 = i;
            }
            return array[minIndex2] + array[minIndex1];
        }
    }
}
