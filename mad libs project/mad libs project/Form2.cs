using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mad_libs_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form form3 = new Form3();
                form3.Show();
            }
            if (radioButton2.Checked)
            {
                Form form5 = new Form5();
                form5.Show();
            }
            if (radioButton3.Checked)
            {
                Form form8 = new Form9();
                form8.Show();
            }
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
