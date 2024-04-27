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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.Text = "I went to the movies yesterday with [1]......... and [2]........... We saw [3].......... It was [4]............ At one part, I even [5]......... and ran for the [6]..........\n. During the move, we ate [7]............ and [8].................. I got mad because the person sitting behind me kept [9].............. during the movie and wouldn't stop [10]............... He was asked to leave after he [11]............. across the theatre.\n It was pretty [12].............. Overall, I liked the movie because it was [13]............. and the main character was super [14]............... Hopefully next time the people sitting behind me will be more [15]...............\r\n.";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            str.str1 = textBox1.Text;
            str.str2 = textBox2.Text;
            str.str3 = textBox3.Text;
            str.str4 = textBox4.Text;
            str.str5 = textBox5.Text;
            str.str6 = textBox6.Text;
            str.str7 = textBox7.Text;
            str.str8 = textBox8.Text;
            str.str9 = textBox9.Text;
            str.str10 = textBox10.Text;
            str.str11 = textBox11.Text;
            str.str12 = textBox12.Text;
            str.str13 = textBox13.Text;
            str.str14 = textBox14.Text;
            str.str15 = textBox15.Text;
            Form form6= new Form6();
            form6.Show();
            
        }
    }
}
