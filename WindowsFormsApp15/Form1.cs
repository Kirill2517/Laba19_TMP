using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            label1.Text = $"X = {CursorXY().X}\nY = {CursorXY().Y}";
        }

        private (int X, int Y) CursorXY()
        {
            int position = textBox1.SelectionStart;                       //позиция курсора
            int row = textBox1.GetLineFromCharIndex(position);  //строка 
            int firstCharIndex = textBox1.GetFirstCharIndexFromLine(row);  // индекс первого символа в стр.

            int column = position - firstCharIndex;
            return (column + 1, row + 1);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) label1.Text = $"X = {CursorXY().X}\nY = {CursorXY().Y}";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings1.Default.PositionX = Location.X;
            Settings1.Default.PositionY = Location.Y;
            Settings1.Default.SizeX = this.Size.Width;
            Settings1.Default.SizeY = this.Size.Height;
            Settings1.Default.TextBox_Text = textBox1.Text;
            Settings1.Default.ColorForms = BackColor;
            Settings1.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(Settings1.Default.PositionX, Settings1.Default.PositionY);
            this.Size = new Size(Settings1.Default.SizeX, Settings1.Default.SizeY);
            textBox1.Text = Settings1.Default.TextBox_Text;
            BackColor = Settings1.Default.ColorForms;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Num3 num3 = new Num3();
            num3.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Num456 num456 = new Num456();
            num456.Show();
        }
    }
}