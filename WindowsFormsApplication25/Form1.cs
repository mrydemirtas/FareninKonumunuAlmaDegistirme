using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iks = 0, ye = 0;
            iks = Cursor.Position.X;
            ye = Cursor.Position.Y;
            x.Text = iks.ToString();
            y.Text = ye.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Position = new Point(int.Parse(x.Text.Trim()), int.Parse(y.Text.Trim()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
