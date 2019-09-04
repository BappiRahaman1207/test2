using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApps
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string planetName = planetNameComboBox.Text;
            if (planetName == "Planet")
            {
                MessageBox.Show("It is in 3rd position");
            }
            else if (planetName == "Saturn")
            {
                MessageBox.Show("It is in 6th position");
            }
            else if (planetName == "Mars")
            {
                MessageBox.Show("It is in 4th position");
            }
            else
            {
                MessageBox.Show("I don’t know");
       
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            planetNameComboBox.Text ="Select Item";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);
            int Sum= firstNumber+ secondNumber;
            ResultTextBox.Text = Sum.ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);
            int Sum = firstNumber - secondNumber;
            ResultTextBox.Text = Sum.ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);
            int Sum = firstNumber * secondNumber;
            ResultTextBox.Text = Sum.ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);
            int Sum = firstNumber / secondNumber;
            ResultTextBox.Text = Sum.ToString();
        }
    }
}
