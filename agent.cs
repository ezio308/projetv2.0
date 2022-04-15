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
    public partial class agent : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        public agent()
        {
            InitializeComponent();
        }

        private void agent_Load(object sender, EventArgs e)
        {


        }
        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            remplirgrid();
        }
        public void remplirgrid()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from bulletins ", cnx);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            cnx.Close();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                //...
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saisie saisie = new saisie();
            saisie.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            remplirgrid1();
        }
        public void remplirgrid1()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from bulletins where login = '" + textBox1 + "'", cnx);
            Reader = cmd.ExecuteReader();
            table1.Load(Reader);
            dataGridView1.DataSource = table1;
            cnx.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Veuillez remplir le champ ID", "MERCI ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cmd = new SqlCommand("delete  from bulletins where NUMBULL ='" + textBox1.Text + "'", cnx);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("suppression effectué avec succes", "cbon", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("veuillez verifier le numero ", "numero n'est pas correcte ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cnx.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
