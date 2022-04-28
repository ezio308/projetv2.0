using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace projet
{
    public partial class gadmbull : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();
        public gadmbull()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Remplirgrid();
        }
        public void Remplirgrid()
        {

            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from bulletins  ", cnx);

            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            cnx.Close();
        }
        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage log = new loginpage();
            log.Show();
        }

        private void gadmbull_Load(object sender, EventArgs e)
        {

        }
    }
}
