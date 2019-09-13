using System;
using ArrayElements;
namespace Byndyusoft
{
     public class Program
    {

        static void Main()
        {
            var array = new double[] {double.NaN};
            Console.WriteLine(MinElements.SummMinimumElementOfArray(array));
        }

    }
}
