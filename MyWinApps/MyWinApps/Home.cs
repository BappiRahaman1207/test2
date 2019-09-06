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
    }
}
