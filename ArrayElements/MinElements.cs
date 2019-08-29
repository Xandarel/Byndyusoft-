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
            HoareSort(array, 0, array.Length - 1);
            return array[0] + array[1];
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
    }
}
