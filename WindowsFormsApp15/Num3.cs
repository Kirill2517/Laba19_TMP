using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Num3 : Form
    {
        public Num3()
        {
            InitializeComponent();
        }

        private List<KnownColor> colors = Enum.GetValues(typeof(KnownColor)).Cast<KnownColor>().ToList();

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            BackColor = Color.FromKnownColor(colors.ElementAt(trackBar1.Value));
            textBox1.Text = colors.ElementAt(trackBar1.Value).ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FormCollection collection = Application.OpenForms;
            collection[0].BackColor = Color.FromKnownColor(colors.ElementAt(trackBar1.Value));
        }

        private void Num3_Load(object sender, EventArgs e)
        {
            colors.RemoveAt(26);
            BackColor = Settings1.Default.ColorForms;
            trackBar1.Value = colors.IndexOf(BackColor.ToKnownColor());
            label1.Text = trackBar1.Value.ToString();
            textBox1.Text = colors.ElementAt(trackBar1.Value).ToString();
        }

        private void Num3_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}