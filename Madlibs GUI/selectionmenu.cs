using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Madlibs_GUI
{
    public partial class selectionmenu : Form
    {
        public selectionmenu()
        {
            InitializeComponent();
        }

        private void selectionmenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Loveprompt = new prompt();
            Loveprompt.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form horrorprompt = new prompt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form happyprompt = new prompt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form sadprompt = new prompt();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form randprompt = new prompt();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
