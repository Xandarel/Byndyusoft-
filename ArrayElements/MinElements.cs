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
                return 0;
            //var min1 = FindMinElements(0, array, 2);
            //var min2 = FindMinElements(1, array, 2);
            //HoareSort(array, 0, array.Length - 1);
            return OneRunForArray(array);
        }

        static void HoareSort(double[] array, int start, int end)
        {
            if (end == start) return;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] <= pivot)
                {
                    var t = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = t;
                    storeIndex++;
                }

            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
            if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
        }

        static double FindMinElements(int start, double[] array, int step)
        {
            var min = array[start];
            for(int i=start+step;i<array.Length;i+=step)
                if (array[i] < min)
                    min = array[i];
            return min;
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
