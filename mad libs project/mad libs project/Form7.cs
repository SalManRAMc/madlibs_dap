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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            label1.Text = "  Last night I went to " + "{" + str.str1 + "}" + " for dinner. The food was" + "{" + str.str2 + "}" + "and" + "{" + str.str3 + "}" + " , but I enjoyed the " + "{" + str.str4 + "}" + " Our waitress was kind of" + "{" + str.str5 + "}" + " because she kept on " + "{" + str.str6 + "}" + " and she got our order" + "{" + str.str7 + "}" + "  She also dropped " + "{" + str.str8 + "}" + "on my mom's " + "{" + str.str9 + "}" + " My mom was really " + "{" + str.str10 + "}" + " because it ruined her" + "{" + str.str11 + "}" + "\\n. For dessert, we got a " + "{" + str.str12 + "}" + " that had " + "{" + str.str13 + "}" + "frosting. It was pretty good but when I was chewing a find a " + "{" + str.str14 + "}" + "in the middle. All in all, it was a " + "{" + str.str5 + "}" + ". restaurant experience.\";\r\n       ";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
          
           
        }
    }
}
