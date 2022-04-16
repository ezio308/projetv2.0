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
        
        public void dataGridView1_UserDeletingRow(object sender, DataGridViewCellEventArgs e)    
        {
            
           
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajouter ajputer = new ajouter();

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
            
            
            
                cmd = new SqlCommand("delete from users where login =  '" + Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value) + "'", cnx);


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

        private void button3_Click(object sender, EventArgs e)
        {   
                modifier modifier = new modifier(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                modifier.Show();
            
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = "sami";
            pdfbulle bull = new pdfbulle(s);
            bull.Show();
        }
    }
}
