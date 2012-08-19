using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace VisualiserDemo
{
    public class DemoObjectVisualiser : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            string contents = new StreamReader(objectProvider.GetData()).ReadToEnd();

            var pictureBox = new PictureBox()
            {
                Size = new Size(100, 100),
                BackColor = Color.FromArgb(int.Parse(contents)),
                Dock = DockStyle.Fill
            };

            windowService.ShowDialog(pictureBox);
        }
    }
}

