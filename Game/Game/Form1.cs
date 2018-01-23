using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            if (radRock.Checked == true)
            {
                radPaper.Visible = false;
                radRock.Visible = false;
                radScissors.Visible = false;
                btnUndo.Visible = true;
            }
        }

      

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (radPaper.Checked == true)
            {
                radPaper.Visible = false;
                radRock.Visible = false;
                radScissors.Visible = false;
                btnUndo.Visible = true;
            }
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            if (radScissors.Checked == true)
            {
                radPaper.Visible = false;
                radRock.Visible = false;
                radScissors.Visible = false;
                btnUndo.Visible = true;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            radPaper.Visible = true;
            radRock.Visible = true;
            radScissors.Visible = true;
            btnUndo.Visible = false;
        }

        private void radRock2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radPaper2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radScissors2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radPaper2.Visible = true;
            radRock2.Visible = true;
            radScissors2.Visible = true;
            btnUndo2.Visible = false;
        }
    }
}
