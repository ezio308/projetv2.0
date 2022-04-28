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
    public partial class ajouter : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int r;
        string s;
        SqlCommand cmd2 = new SqlCommand();
        SqlDataReader Reader;
        SqlDataReader Reader1;
        public ajouter()
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

       

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int v = 1;
            if (login.Text==""|| password.Text == "" || email.Text == "" || prenom.Text == "" || nom.Text == "" || adresse.Text == "" || numtel.Text == "" || codecn.Text == "" )
            {
                v = 0;
            }
            else if (radioButton1.Checked && (nomconjoint.Text == "" || prenomconjoint.Text == "" || nbrenf.Text == "" ))
            {
                v = 0;
            }

             else if (!radioButton2.Checked && !radioButton1.Checked)
            {
                v = 0;
            }

            else if (listBox1.SelectedIndex == -1)

            {
                v = 0;
            }
            else if (listBox2.SelectedIndex == -1)

            {
                v = 0;
            }
            else {
                cnx.Open();
                cmd2 = new SqlCommand("select * from users where login='" + login.Text + "'", cnx);
                Reader1 = cmd2.ExecuteReader();
                if (Reader1.HasRows)
                {
                    MessageBox.Show("employe deja existe", "attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    v = 0;
                    cnx.Close();
                }
                
            }
            if (v == 0)
            {
                MessageBox.Show("veuillez remplir tous les champs", "attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else 
            {
                if (nbrenf.Text == "")
                {
                    nbrenf.Text = "0";
                }
                if (listBox2.SelectedIndex == 0)
                {
                    r = 3;
                }
                else if (listBox2.SelectedIndex == 1)
                {
                    r = 1;
                }
                else if (listBox2.SelectedIndex == 2)
                {
                    r = 2;
                }
                if (radioButton1.Checked)
                {
                    s = "marié";
                }
                else if (radioButton2.Checked)
                {
                    s = "célibataire";
                }
                int x = int.Parse(this.listBox1.GetItemText(this.listBox1.SelectedItem));
                int y = int.Parse(nbrenf.Text);
                Deconnecter();
                cnx.Open();
                //  cmd = new SqlCommand("INSERT INTO users   VALUES ('" + login.Text + "','" + password.Text + "','" + id.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "'," + grade.Text + ",'" + numtel.Text + "','" + codecn.Text + "','" + etatcivil.Text + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "'," + nbrenf.Text + "," + role.Text + ")", cnx);
                if (x == 1)
                {
                    cmd = new SqlCommand("INSERT INTO users (login,password,email,name,lastname,adresse,grade,tel,codecn,etatcivil,nomconjoint,prenomconjoint,nombreenfants,role,daten,plafond) VALUES ('" + login.Text + "','" + password.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "','" + x + "','" + numtel.Text + "','" + codecn.Text + "','" + s + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "','" + y + "','" + r + "','" + dateTimePicker1.Value.ToString() + "',1800)", cnx);
                }
                else if (x == 2)
                {
                    cmd = new SqlCommand("INSERT INTO users (login,password,email,name,lastname,adresse,grade,tel,codecn,etatcivil,nomconjoint,prenomconjoint,nombreenfants,role,daten,plafond) VALUES ('" + login.Text + "','" + password.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "','" + x + "','" + numtel.Text + "','" + codecn.Text + "','" + s + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "','" + y + "','" + r + "','" + dateTimePicker1.Value.ToString() + "',1400)", cnx);

                }
                else if (x == 3)
                {
                    cmd = new SqlCommand("INSERT INTO users (login,password,email,name,lastname,adresse,grade,tel,codecn,etatcivil,nomconjoint,prenomconjoint,nombreenfants,role,daten,plafond) VALUES ('" + login.Text + "','" + password.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "','" + x + "','" + numtel.Text + "','" + codecn.Text + "','" + s + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "','" + y + "','" + r + "','" + dateTimePicker1.Value.ToString() + "',1000)", cnx);
                }
                else if (x == 4)
                {
                    cmd = new SqlCommand("INSERT INTO users (login,password,email,name,lastname,adresse,grade,tel,codecn,etatcivil,nomconjoint,prenomconjoint,nombreenfants,role,daten,plafond) VALUES ('" + login.Text + "','" + password.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "','" + x + "','" + numtel.Text + "','" + codecn.Text + "','" + s + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "','" + y + "','" + r + "','"+ dateTimePicker1.Value.ToString() + "',600)", cnx);

                }
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




            }
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }

        private void etatcivil_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nomconjoint.Enabled = true;
            prenomconjoint.Enabled = true;
            nbrenf.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nomconjoint.Enabled = false;
            prenomconjoint.Enabled = false;
            nbrenf.Enabled = false;
        }

        private void nbrenf_TextChanged(object sender, EventArgs e)
        {

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
    

