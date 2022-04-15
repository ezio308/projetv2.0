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
    public partial class admin : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();
        public admin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter ajputer = new Ajouter();

            ajputer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Remplirgrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rechercher rechercher = new rechercher();
            rechercher.Show();
        }
        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        public void Remplirgrid()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from users ", cnx);

            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            cnx.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();
            if (ID.Text == "")
            {
                MessageBox.Show("Veuillez remplir le champ ID", "MERCI ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                cmd = new SqlCommand("delete  from users where ID='" + ID.Text + "'", cnx);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("suppression effectué avec succes", "cbon", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("veuillez verifier l'ID ", "ID n'est pas correcte ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cnx.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   if (ID.Text == "")
            {
                MessageBox.Show("Veuillez remplir le champ ID", "MERCI ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                modifier modifier = new modifier(ID.Text);
                modifier.Show();
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pdfbulle bull = new pdfbulle(ID.Text);
            bull.Show();
        }
    }
}
