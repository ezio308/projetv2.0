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
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-N8SA1K2\SQLEXPRESS;Initial Catalog=dbp;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
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
            int x = int.Parse(grade.Text);

            int y = int.Parse(nbrenf.Text);
            Deconnecter();
            cnx.Open();
            //  cmd = new SqlCommand("INSERT INTO users   VALUES ('" + login.Text + "','" + password.Text + "','" + id.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "'," + grade.Text + ",'" + numtel.Text + "','" + codecn.Text + "','" + etatcivil.Text + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "'," + nbrenf.Text + "," + role.Text + ")", cnx);
            if (x == 1)
            {
                cmd = new SqlCommand("INSERT INTO users (login,password,ID,email,name,lastname,adresse,grade,tel,codecn,etatcivil,nomconjoint,prenomconjoint,nbrenfants,role,datenaiss,plafond) VALUES ('" + login.Text + "','" + password.Text + "','" + id.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "','" + x + "','" + numtel.Text + "','" + codecn.Text + "','" + etatcivil.Text + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "','" + y + "','" + listBox2.SelectedItem.ToString() + "','" + dateTimePicker1.Value.ToString() + "',1800)", cnx);
            }
            else if (x == 2)
            {
                cmd = new SqlCommand("INSERT INTO users (login,password,ID,email,name,lastname,adresse,grade,tel,codecn,etatcivil,nomconjoint,prenomconjoint,nbrenfants,role,datenaiss,plafond) VALUES ('" + login.Text + "','" + password.Text + "','" + id.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "','" + x + "','" + numtel.Text + "','" + codecn.Text + "','" + etatcivil.Text + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "','" + y + "','" + listBox2.SelectedItem.ToString()+ "','" + dateTimePicker1.Value.ToString() + "',1400)", cnx);

            }
            else if (x == 3)
            {
                cmd = new SqlCommand("INSERT INTO users (login,password,ID,email,name,lastname,adresse,grade,tel,codecn,etatcivil,nomconjoint,prenomconjoint,nbrenfants,role,datenaiss,plafond) VALUES ('" + login.Text + "','" + password.Text + "','" + id.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "','" + x + "','" + numtel.Text + "','" + codecn.Text + "','" + etatcivil.Text + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "','" + y + "','" + listBox2.SelectedItem.ToString() + "','" + dateTimePicker1.Value.ToString() + "',1000)", cnx);

            }
            else if (x == 4)
            {
                cmd = new SqlCommand("INSERT INTO users (login,password,ID,email,name,lastname,adresse,grade,tel,codecn,etatcivil,nomconjoint,prenomconjoint,nbrenfants,role,datenaiss,plafond) VALUES ('" + login.Text + "','" + password.Text + "','" + id.Text + "','" + email.Text + "','" + prenom.Text + "','" + nom.Text + "','" + adresse.Text + "','" + x + "','" + numtel.Text + "','" + codecn.Text + "','" + etatcivil.Text + "','" + nomconjoint.Text + "','" + prenomconjoint.Text + "','" + y + "','" + listBox2.SelectedItem.ToString() + "','" + dateTimePicker1.Value.ToString() + "',600)", cnx);

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

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }
    }
}
    

