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
  
    public partial class modifier : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        public modifier(string str_value)
        {


            InitializeComponent();
            remplissage(str_value);
        }

        public void remplissage(string x)
        {
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("select * from users where ID='" + x + "'", cnx);

            Reader = cmd.ExecuteReader();
            Reader.Read();
            login.Text = Convert.ToString(Reader["login"]);
            password.Text = Convert.ToString(Reader["password"]);
            id.Text = Convert.ToString(Reader["ID"]);
            adresse.Text = Convert.ToString(Reader["adresse"]);
            nom.Text = Convert.ToString(Reader["name"]);
            prenom.Text = Convert.ToString(Reader["lastname"]);
            grade.Text = Convert.ToString(Reader["grade"]);
            role.Text = Convert.ToString(Reader["role"]);
            email.Text = Convert.ToString(Reader["email"]);
            etatcivil.Text = Convert.ToString(Reader["etatcivil"]);
            codecn.Text = Convert.ToString(Reader["codecn"]);
            nomconjoint.Text = Convert.ToString(Reader["nomconjoint"]);
            prenomconjoint.Text = Convert.ToString(Reader["prnomconjoint"]);
            numtel.Text = Convert.ToString(Reader["tel"]);
            nbrenf.Text = Convert.ToString(Reader["nbrenf"]);
            Date.Text = Convert.ToString(Reader["datenaiss"]);


            cnx.Close();

        }
        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        private void modifier_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x, y, z;
            x = int.Parse(grade.Text);
            z = int.Parse(role.Text);
            Deconnecter();
            cnx.Open();


            if (listBox1.SelectedIndex != -1)
            {
                etatcivil.Text = listBox1.SelectedItem.ToString();
            }
         
                if (nbrenf.Text == "")
                {



                    cmd = new SqlCommand("update  users set login='" + login.Text + "',password='" + password.Text + "',ID='" + id.Text + "',adresse='" + adresse.Text + "',name='" + nom.Text + "',lastname='" + prenom.Text + "',email='" + email.Text + "',etatcivil='" + etatcivil.Text + "',codecn='" + codecn.Text + "',tel='" + numtel.Text + "',role='" + z + "',grade='" + x + "',datenaiss='" + Date.Value.ToString() + "' where ID='" + id.Text + "'", cnx);
                }
                else
                {
                    y = int.Parse(nbrenf.Text);
                    cmd = new SqlCommand("update  users set login='" + login.Text + "',password='" + password.Text + "',ID='" + id.Text + "',adresse='" + adresse.Text + "',name='" + nom.Text + "',lastname='" + prenom.Text + "',email='" + email.Text + "',etatcivil='" + etatcivil.Text + "',codecn='" + codecn.Text + "',tel='" + numtel.Text + "',role='" + z + "',grade='" + x + "',datenaiss='" + Date.Value.ToString() + "',nombreenfants='" + y + "',nomconjoint='" + nomconjoint.Text + "',prenomconjoint='" + prenomconjoint.Text + "' where ID='" + id.Text + "'", cnx);

                }
            
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("modifier effectuée avec succes", "cbon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
          
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
