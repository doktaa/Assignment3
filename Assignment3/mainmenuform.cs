using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Assignment3
{
    public partial class mainmenuform : Form
    {
        public mainmenuform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void officerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            officerform a = new officerform();
            a.Closed += (s, args) => this.Close();
            a.ShowDialog();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainmenutitle_Click(object sender, EventArgs e)
        {

        }

        private void ambulancebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ambulanceform a = new ambulanceform();
            a.Closed += (s, args) => this.Close();
            a.ShowDialog();
        }

        private void checkrosterbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkrosterform a = new checkrosterform();
            a.Closed += (s, args) => this.Close();
            a.ShowDialog();
        }
    }
}
