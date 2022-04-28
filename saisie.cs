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
using System.Text.RegularExpressions;

namespace projet
{
    public partial class saisie : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
      
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        SqlCommand cmd3 = new SqlCommand();
        SqlCommand cmd4 = new SqlCommand();
        SqlCommand cmd5 = new SqlCommand();
        SqlDataReader Reader; 
        SqlDataReader Reader1;
        SqlDataReader Reader2;

        public saisie(string nom)
        {
            InitializeComponent();
            textBox2.Text= nom;
            
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

        Boolean alphanum(string ch)
        {
            return Regex.IsMatch(ch, @"^[a-zA-Z0-9]+$") && ch.Length != 0;
        }
        Boolean num(string ch)
        {
            return Regex.IsMatch(ch, @"^[0-9]+$") && ch.Length != 0;
        }
        Boolean mat(string ch)
        {
            return Regex.IsMatch(ch, @"^[a-zA-Z0-9]+$") && ch.Length != 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("select numbull from bulletins where login='" + textBox5.Text + "'and datedepot LIKE '" + DateTime.Now.Year + "%'", cnx);

            Reader = cmd.ExecuteReader();


            if (!Reader.HasRows)
            {
                cnx.Close();

                Deconnecter();
                cnx.Open();
                cmd2 = new SqlCommand("update users set plafond='" + 1800 + "'  where login='" + textBox5.Text + "' and grade='" + 1 + "'", cnx);
                cmd3 = new SqlCommand("update users set plafond='" + 1400 + "'  where login='" + textBox5.Text + "' and grade='" + 2 + "'", cnx);
                cmd4 = new SqlCommand("update users set plafond='" + 1000 + "'  where login='" + textBox5.Text + "' and grade='" + 3 + "'", cnx);
                cmd5 = new SqlCommand("update users set plafond='" + 600 + "'  where login='" + textBox5.Text + "' and grade='" + 4 + "'", cnx);
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cnx.Close();
            }
            int v = 1;
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || !alphanum(textBox1.Text))
            {
                v = 0;
            }
            Deconnecter();
            cnx.Open();
            cmd2 = new SqlCommand("select * from bulletins where NUMBULL='" + textBox1.Text + "'", cnx);
            Reader1 = cmd2.ExecuteReader();

            float y = (float)(float.Parse(textBox4.Text));
            // string x = textBox4.Text.ToString().Trim();
            //float.TryParse(x, out y);
            if (Reader1.HasRows)
            {
                v = 2;
            }
            cnx.Close();
            cnx.Open();
            cmd2 = new SqlCommand("select * from users where login='" + textBox5.Text + "'", cnx);
            Reader2 = cmd2.ExecuteReader();

            if (!Reader2.HasRows)
            {
                v = 3;
                cnx.Close();
            }
            if (v == 0)
            {
                MessageBox.Show(" Remplire tous les champs ", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (v == 2)
            {
                MessageBox.Show(" Ce numero de bulletin deja existe", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (v == 3)
            {
                MessageBox.Show("employe n'existe pas", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (v == 1)
            {
                Deconnecter();
                cnx.Open();
                cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = "INSERT INTO bulletins(NUMBULL,actedesc,login,agent,actefrais,datedepot) VALUES ( @a,@b,@c,@d,@e,@f);";
                cmd.Parameters.AddWithValue("@f", this.dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@a", this.textBox1.Text);
                cmd.Parameters.AddWithValue("@b", this.textBox3.Text);
                cmd.Parameters.AddWithValue("@c", this.textBox5.Text);
                cmd.Parameters.AddWithValue("@d", this.textBox2.Text);
                cmd.Parameters.AddWithValue("@e", this.textBox4.Text);

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
                verification verif = new verification(y, textBox5.Text, textBox1.Text, dateTimePicker1.Value.ToString(), textBox2.Text);
                verif.Show();
            }
        }
        private void saisie_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage log = new loginpage();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
