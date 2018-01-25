using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random randNumber = new Random();
            randomNumber = randNumber.Next(1, 10);
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Random randNumber = new Random();
            randomNumber = randNumber.Next(1, 20);
            txtNumberGuess.Clear();
            lblOutput.Text = string.Empty;
        }

        int randomNumber;
        

            
        private void btnGuess_Click(object sender, EventArgs e)
        {
            string input;
            int guess;
                  

            input = txtNumberGuess.Text;
            guess = Convert.ToInt32(input);


            if (guess != randomNumber)
            {
                if (guess > randomNumber)
                {
                    lblOutput.Text = "You guessed to high. Try again.";
                }
                else if (guess < randomNumber)
                {
                    lblOutput.Text = "You guessed to low. Try again.";
                }
                 
            }
            else
            {
                lblOutput.Text = "You guessed it right! the number was " + randomNumber + "!";

            }
        }

             
    }
}
