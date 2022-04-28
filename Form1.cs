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
    public partial class Form1 : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-N8SA1K2\SQLEXPRESS;Initial Catalog=dbp;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        public Form1()
        {
            InitializeComponent();
            remplirgrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
        }
        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        public void remplirgrid()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from users where role = 2 ", cnx);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            cnx.Close();
        }
        public void Remplirgrid1()
        {

            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand(" select * from bulletins where agent = '" + Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value) + "'", cnx);

            Reader = cmd.ExecuteReader();
            table1.Load(Reader);
            dataGridView2.DataSource = table1;
            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Remplirgrid1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage log = new loginpage();
            log.Show();
        }
    }
}
