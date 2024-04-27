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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            label1.Text = "I went to the movies yesterday with " + "{" + str.str1 + "}" + " and " + "{" + str.str2 + "}" + ".We saw " + "{" + str.str3 + "}" + " It was" + "{" + str.str4 + "}" + ".\n. At one part, I even" + "{" + str.str5 + "}" + " and ran for the" + "{" + str.str6 + "}" + ". During the move, we ate " + "{" + str.str7 + "}" + " and " + "{" + str.str8 + "}" + ". I got mad because the person sitting behind me kept" + "{" + str.str9 + "}" + " during the movie and wouldn't stop" + "{" + str.str10 + "}" + ". He was asked to leave after he" + "{" + str.str11 + "}" + " across the theatre. It was pretty" + "{" + str.str12 + "}" + ". Overall, I liked the movie because it was " + "{" + str.str13 + "}" + " and the main character was super " + "{" + str.str14 + "}" + ". Hopefully next time the people sitting behind me will be more " + "{" + str.str2 + "}" + ".";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
