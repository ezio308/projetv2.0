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
    public partial class modifiers : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        public modifiers(string str_value)
        {


            InitializeComponent();
            remplissage(str_value);
        }
        public void remplissage(string x)
        {
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("select * from bulletins where NUMBULL ='" + x + "'", cnx);

            Reader = cmd.ExecuteReader();
            Reader.Read();
            textBox1.Text = Convert.ToString(Reader["NUMBULL"]);
            textBox1.Enabled = false;
            textBox4.Enabled = false;
            dateTimePicker1.Text = Convert.ToString(Reader["datedepot"]);
            textBox3.Text = Convert.ToString(Reader["actedesc"]);
            textBox5.Text = Convert.ToString(Reader["login"]);
           


            cnx.Close();
        }
        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        private void modifiers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();

            string selectDateAsString = dateTimePicker1.Value.ToString("yyyyMMdd");
            cmd = new SqlCommand("update  bulletins set datedepot='" + selectDateAsString + "',actedesc ='" + textBox3.Text + "',login ='" + textBox5.Text + "'where NUMBULL='" + textBox1.Text+"' ", cnx);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("modifier effectuée avec succes", "cbon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage log = new loginpage();
            log.Show();
        }
    }
}
