using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AgeCalc : Form
    {
        public AgeCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int age;
            age = Convert.ToInt16(textBox1.Text);
            int calc = 2024 - age;
            label2.Text = Convert.ToString(calc);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
