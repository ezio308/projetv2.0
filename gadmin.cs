﻿using System;
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
    public partial class gadmin : Form
    {
        public gadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            admin.Remplirgrid();
        }

        private void gadmin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "mohsen";
            pdfbulle bpdf = new pdfbulle();
            bpdf.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this .Hide();
            somme som = new somme();
            som.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gadmbull ga = new gadmbull();
            ga.Show();

        }
    }
}
