using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class gagent : Form
    {
        public gagent(string nom)
        {
            InitializeComponent();
            label2.Text = nom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            saisie saisie = new saisie(label2.Text);
            saisie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            agent agent = new agent();
            agent.Show();
            agent.remplirgrid();
        }

        private void gagent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage log = new loginpage();
            log.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
