using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Input Username");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Input Password");
            }
            else if (textBox1.Text == "user" && textBox2.Text == "pass123")
            {
                Main ss = new Main();
                ss.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Username Or Password Invalid");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
