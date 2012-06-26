using System;
using System.Linq;
using System.Windows.Forms;

namespace VisualiserDemo
{
    public partial class DemoObjectVisualiserForm : Form
    {
        private DemoObject _objectToVisualise;

        public DemoObjectVisualiserForm()
        {
            InitializeComponent();
        }

        public DemoObjectVisualiserForm(DemoObject objectToVisualise)
            : this()
        {
            _objectToVisualise = objectToVisualise;
            ShowObject();
        }

        private void ShowObject()
        {
            var arrayTable = string.Empty;

            //Loop through each element and show its value in a table
            foreach (var i in Enumerable.Range(0, _objectToVisualise.IntArray.GetUpperBound(0)))
            {
                foreach (var j in Enumerable.Range(0, _objectToVisualise.IntArray.GetUpperBound(1)))
                {
                    arrayTable += _objectToVisualise.IntArray[i, j].ToString() + '\t';
                }
                arrayTable += Environment.NewLine;
            }

            arrayContents.Text = arrayTable;

            //visualise the colour
            colourBox.BackColor = _objectToVisualise.Colour;
        }

    }
}
