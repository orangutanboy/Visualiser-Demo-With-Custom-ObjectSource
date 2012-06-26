using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualiserDemo
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void doStuffButton_Click(object sender, EventArgs e)
        {
            var initialColour = Color.DarkOrange;
            var intArray = ArrayBuilder.InitialiseRandomArray(18, 7);

            var demoObject = new DemoObject(initialColour, intArray);

            System.Diagnostics.Debugger.Break();
            this.Close();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupForm());
        }
    }
}
