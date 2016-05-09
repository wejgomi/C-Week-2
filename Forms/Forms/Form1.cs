using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Year >= dateTimePicker2.Value.Year)
            {
                MessageBox.Show("Please select a relevant birthdate !");
            }
            else if (((dateTimePicker2.Value.Day - dateTimePicker1.Value.Day) != 0))
            {
                //MessageBox.Show(inputText1 + " has " + (dateTimePicker2.Value.Day - dateTimePicker1.Value.Day) + " days before his/her birthday !");
                MessageBox.Show(String.Format("{0} has {1} days before his/her birthday !", inputText1.Text, (365 -(dateTimePicker2.Value.Day - dateTimePicker1.Value.Day))));
            }
            else
            { //MessageBox.Show("Today is " + inputText1 + "'s birthday !"); 
                MessageBox.Show(String.Format("Today is {0}'s birthday !", inputText1.Text));
                //MessageBox.Show("First date is: " + date1 + ", while the second date is: " + date2);
                //MessageBox.Show("User " + inputText1.Text + " is " + inputText2.Text + " years old !");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void inputText1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
