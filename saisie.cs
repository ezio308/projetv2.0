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
using System.Data.Sql;
using System.Configuration;

namespace projet
{
    public partial class saisie : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
      
        SqlCommand cmd = new SqlCommand();

        public saisie()
        {
            InitializeComponent();
        }
        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox4.Text);
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("INSERT INTO bulletins(NUMBULL,datedepot,actedesc,actefrais,login) VALUES ('" + textBox1.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox3.Text + "','" + x + "','" + textBox5.Text + "')", cnx);
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                MessageBox.Show("Ajout effectué avec succes", "cbon", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cnx.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("verfiez les données", "resseyez", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Hide();
            verification verif = new verification(textBox4.Text,textBox5.Text,textBox1.Text, dateTimePicker1.Value.ToString());
            verif.Show();


        }

        private void saisie_Load(object sender, EventArgs e)
        {

        }
    }
}
