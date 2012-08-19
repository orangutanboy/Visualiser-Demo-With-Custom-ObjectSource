using System.IO;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace VisualiserDemo
{
    public class DemoObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, System.IO.Stream outgoingData)
        {
            var demoObject = target as DemoObject;
            var streamWriter = new StreamWriter(outgoingData);
            streamWriter.Write(demoObject.Colour.ToArgb());
            streamWriter.Flush();
        }
    }
}
