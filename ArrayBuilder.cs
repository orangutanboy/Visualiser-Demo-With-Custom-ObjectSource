using System.Linq;
using System;

namespace VisualiserDemo
{
    public class ArrayBuilder
    {
        public static int[,] InitialiseRandomArray(int dimension1, int dimension2)
        {
            var random = new Random();

            var intArray = new int[dimension1, dimension2];

            foreach (var i in Enumerable.Range(0, dimension1))
            {
                foreach (var j in Enumerable.Range(0, dimension2))
                {
                    intArray[i, j] = random.Next(0, 255);
                }
            }

            return intArray;
        }

    }
}
