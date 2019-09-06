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
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string Name = firstName+" "+ lastName;
            MessageBox.Show(Name);
        }

        private void ParentsNameButton_Click(object sender, EventArgs e)
        {
            string fatherName = fatherNameTextBox.Text;
            string motherName = motherNameTextBox.Text;
           
            MessageBox.Show("Father's Name: " + fatherName +"\n" +"Mother's Name: "+motherName);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            string Address = addressTextBox.Text;
            MessageBox.Show(Address);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved Successfully!");
        }

        private void ShowAllInformationButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string fatherName = fatherNameTextBox.Text;
            string motherName = motherNameTextBox.Text;
            string Address = addressTextBox.Text;

            MessageBox.Show(firstName+"\n"+lastName+"\n"+fatherName+"\n"+motherName+"\n"+Address);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }
    }
}
