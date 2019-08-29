using System;
using ArrayElements;
namespace Byndyusoft
{
     public class Program
    {

        static void Main()
        {
            var array = new double[] { 5, 1, 9, 0, -1 };
            Console.WriteLine(MinElements.SummMinimumElementOfArray(array));
        }

    }
}
