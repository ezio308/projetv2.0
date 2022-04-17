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
            dateTimePicker1.Text = Convert.ToString(Reader["datedepot"]);
            textBox3.Text = Convert.ToString(Reader["actedesc"]);
            textBox4.Text = Convert.ToString(Reader["actefrais"]);
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
            float x = float.Parse(textBox4.Text);
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("update  bulletins set datedepot='" + dateTimePicker1.Value.ToString() + "',actedesc ='" + textBox3.Text + "',actefrais='" + x + "',login ='" + textBox5.Text +  "'", cnx);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("modifier effectuée avec succes", "cbon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
        }
    }
}
