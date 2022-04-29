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
           
        }
        public void remplirgrid()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select login,name,lastname,adresse,grade from users ", cnx);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            cnx.Close();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifiers modifiers = new modifiers(Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value));
            modifiers.Show();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();
            if (dateTimePicker1.Value.ToString() == "")
            {
                MessageBox.Show("Veuillez remplir le champ date SVP", "MERCI ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cmd = new SqlCommand("delete  from bulletins where NUMBULL ='" + Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value) + "'", cnx);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("suppression effectué avec succes", "cbon", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("veuillez verifier  ", "numero n'est pas correcte ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cnx.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Remplirgrid1();
        }
        public void Remplirgrid1()
        {

            Deconnecter();
            cnx.Open();
            string selectDateAsString = dateTimePicker1.Value.ToString("yyyyMMdd");
            cmd = new SqlCommand("select * from  bulletins where datedepot ='" + selectDateAsString  + "'and login ='" + Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value)+"'", cnx);

            Reader = cmd.ExecuteReader();
            table1.Load(Reader);
            dataGridView2.DataSource = table1;
            cnx.Close();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage log = new loginpage();
            log.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
