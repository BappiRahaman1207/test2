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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home newForm = new Home();
            newForm.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List <int> numbers= new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);


            List<string> names = new List<string>();

            names.Add("Ali");
            names.Add("jam");
            names.Add("Lcuy");
            names.Add("Halen");

            string message = "";
            int index = 0;
            message = message + "Foreach:\n";

            foreach (int number in numbers)
            {
                message = message +names[index] + " "+ number+"\n";
                index++;
            }

            message = message + "For:\n";

            for (int i = 0; i < numbers.Count-1; i++)
            {

                message = message +names[i] +" "+ numbers [i]+ "\n";
            }

            ShowRichTextBox.Text = message;
        }
    }
}
