using System;
using System.Drawing;

namespace VisualiserDemo
{
    public class DemoObject
    {
        public DemoObject(Color colour, int[,] intArray)
        {
            Colour = colour;
            IntArray = intArray;
        }

        public int[,] IntArray { get; private set; }
        public Color Colour { get; set; }
    }
}
