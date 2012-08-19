using System.Diagnostics;
using System.Drawing;

namespace VisualiserDemo
{
    [DebuggerVisualizer(typeof(DemoObjectVisualiser), typeof(DemoObjectSource))]
    public class DemoObject
    {
        public Color Colour { get; set; }
    }
}
