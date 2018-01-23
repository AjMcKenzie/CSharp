using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblOutPut.Text = String.Empty;

            int numGreetings = Convert.ToInt32(txtGreetings.Text);
            int count;

            for (count = 0; count < numGreetings; ++count)
                lblOutPut.Text += "Hello\n";
        }
    }
}
