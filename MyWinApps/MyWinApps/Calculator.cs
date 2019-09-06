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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(SecondNumberTextBox.Text);
            int Sum = firstNumber + secondNumber;
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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }
    }
}
