using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace robot_bobot
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void main_pannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void figure_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void main_pannel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Text = "x: " + e.X.ToString() + "; y: " + e.Y.ToString();
        }

    }
}
