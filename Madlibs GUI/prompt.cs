using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlibs_GUI
{
    public partial class prompt : Form
    {
        Love love = new Love();
        string template;
        Random random = new Random();
        public prompt()
        {
            InitializeComponent();
            template = love.Take(random.Next(0, 5));
            label1.Text = template;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
