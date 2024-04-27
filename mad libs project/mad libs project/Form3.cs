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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Text = "Thank you, ladies and [1]..... I’m so nervous. My is beating a/an [2]......... a minute/n. I didn’t prepare a/an [3]............ I never expected to win this [4]........Oscar. I have so many people to [5].......... First and foremost, my [6]........... costar——who was always in my dressing [7]............, held my [8].........when I was in trouble, and never failed to compliment me or give me a/an pat on my [9].......... when I did well. I also want to thank my [10]............ director, my [11].......... producer, and of course, the [12]......... writer of the screenplay. Most of all, I want to thank you, my [13]......... fans, and all the members of the Motion Picture [14]............ who were responsible for my [15]........ this [16]........ award. Bless your [17]..........";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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
            str.str16 = textBox16.Text;
            str.str17 = textBox17.Text;

           Form form4 = new Form4();
            form4.Show();
        }

    }
}
