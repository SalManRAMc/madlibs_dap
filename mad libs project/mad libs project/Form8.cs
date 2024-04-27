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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            label1.Text = "Last night I went to [1]......... for dinner. The food was [2]........ and [3].........., but I enjoyed the [4]........................... . Our waitress was kind of [5] ................... because she kept on [6]............. and she got our oder [7]........................... She also dropped [8].................on my mom's [9].................... My mom was really [10]............. because it ruined her [11]..................\n. For dessert, we got a [12]............ that had [13]............frosting. It was pretty good but when I was chewing a find a [14]...............in the middle. All in all, it was a [15]......................... restaurant experience.";
       
        }

        private void Form8_Load(object sender, EventArgs e)
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
            Form form7 = new Form7();
            form7.Show();

        }
    }
}
