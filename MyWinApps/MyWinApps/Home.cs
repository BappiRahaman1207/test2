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

        private void ComboBoxButton_Click(object sender, EventArgs e)
        {
            ComboBox newForm = new ComboBox();
            newForm.Show();
            this.Hide();
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Calculator newForm = new Calculator();
            newForm.Show();
            this.Hide();
        }

        private void PersonalInformationButton_Click(object sender, EventArgs e)
        {
            PersonalInformation newForm = new PersonalInformation();
            newForm.Show();
            this.Hide();
        }

        private void CoffeeShopButton_Click(object sender, EventArgs e)
        {
            CoffeeShop newForm = new CoffeeShop();
            newForm.Show();
            this.Hide();
        }

        private void ArrayButton_Click(object sender, EventArgs e)
        {
            Array newForm = new Array();
            newForm.Show();
            this.Hide();
        }

        private void LoopUiButton_Click(object sender, EventArgs e)
        {
            ArrayProgram1 newForm = new ArrayProgram1();
            newForm.Show();
            this.Hide();
        }

        private void ArrayProgram2Button_Click(object sender, EventArgs e)
        {
            ArrayProgram2 newForm = new ArrayProgram2();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayDuplicate newForm = new ArrayDuplicate();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Method newForm = new Method();
            newForm.Show();
            this.Hide();
        }
    }
}
