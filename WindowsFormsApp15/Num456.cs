using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Num456 : Form
    {
        public Num456()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.Series[0].Points.Clear();
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                int x = 1;
                int y = 0;
                while (!streamReader.EndOfStream)
                {
                    y = Convert.ToInt32(streamReader.ReadLine());
                    chart1.Series[0].Points.AddXY(x, y);
                    x++;
                }
                chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
                chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

                chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
                chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
                streamReader.Close();
            }
            

        }
    }
}
