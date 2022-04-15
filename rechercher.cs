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
    public partial class rechercher : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();
        public rechercher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void valider_Click(object sender, EventArgs e)
        {
            Remplirgrid();
        }
        public void Remplirgrid()
        {

            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from users where id='" + ID.Text + "'", cnx);

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

        private void clear_Click(object sender, EventArgs e)
        {
            ID.Clear();
            int index = this.dataGridView1.CurrentRow.Index;
            this.dataGridView1.Rows.RemoveAt(index);
        }
    }
}
