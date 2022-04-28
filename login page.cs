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
    public partial class loginpage : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        public loginpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            gadmin gadmin = new gadmin();
            gagent agent = new gagent(textBox2.Text);
            employe employe = new employe(textBox2.Text);

            
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Veuillez remplir les 2 champs");
            }


            else

            {
                Deconnecter();
                cnx.Open();

                cmd = new SqlCommand("select role from users where login='" + textBox2.Text + "'and password='" + textBox3.Text +"'", cnx);     

                Reader = cmd.ExecuteReader();
                Reader.Read();
                

                if (!Reader.HasRows)
                {
                    MessageBox.Show("verifier le login et le mot de passe ", "réessayer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string x = Convert.ToString(Reader["role"]);
                    cnx.Close();
                    if (x == "1")
                    {
                        this.Hide();
                        gadmin.Show();
                    }
                    else if (x == "2")
                    {
                        this.Hide();
                        agent.Show();
                    }
                    else if (x == "3")
                    {
                        this.Hide();
                        employe.Show();


                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}