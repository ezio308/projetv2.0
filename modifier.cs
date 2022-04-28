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
        SqlCommand cmd1 = new SqlCommand();
        SqlDataReader Reader;
        public modifier(string str_value)
        {


            InitializeComponent();
            remplissage(str_value);
            fillcombo();
        }
        public void fillcombo()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select DISTINCT ((grade)) from users ", cnx);
            Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {

                while (Reader.Read())
                {
                    String d = Convert.ToString(Reader[0]);
                    listBox1.Items.Add(d);
                }
            }
        }

        public void remplissage(string x)
        {
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("select * from users where login='" + x + "'", cnx);

            Reader = cmd.ExecuteReader();
            Reader.Read();
            login.Text = Convert.ToString(Reader["login"]);
            
            adresse.Text = Convert.ToString(Reader["adresse"]);
            nom.Text = Convert.ToString(Reader["name"]);
            prenom.Text = Convert.ToString(Reader["lastname"]);       
            email.Text = Convert.ToString(Reader["email"]);
            etatcivil.Text = Convert.ToString(Reader["etatcivil"]);
            codecn.Text = Convert.ToString(Reader["codecn"]);
            nomconjoint.Text = Convert.ToString(Reader["nomconjoint"]);
            prenomconjoint.Text = Convert.ToString(Reader["prenomconjoint"]);
            numtel.Text = Convert.ToString(Reader["tel"]);
            nbrenf.Text = Convert.ToString(Reader["nombreenfants"]);
           


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

            int x, y;
            
            int r;
            Deconnecter();
            cnx.Open();
            int v = 1;
            if (login.Text == "" ||  email.Text == "" || prenom.Text == "" || nom.Text == "" || adresse.Text == "" || numtel.Text == "" || codecn.Text == "")
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
            if (v == 0)
            {
                MessageBox.Show("veuillez remplir tous les champs", "attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                x = int.Parse(this.listBox2.GetItemText(this.listBox2.SelectedItem));
                if (listBox1.SelectedIndex != -1)
                {
                    etatcivil.Text = listBox1.SelectedItem.ToString();
                }
                if (nbrenf.Text == "")
                {
                    nbrenf.Text = "0";
                }
                y = int.Parse(nbrenf.Text);
                   cmd = new SqlCommand("update  users set adresse='" + adresse.Text + "',name='"+nom.Text+ "', lastname='" + prenom.Text + "',email='" + email.Text + "',etatcivil='" + etatcivil.Text + "',codecn='" + codecn.Text + "',tel='" + numtel.Text + "',grade='" + x + "',nombreenfants='" + y + "',nomconjoint='" + nomconjoint.Text + "',prenomconjoint='" + prenomconjoint.Text + "' where login='" + login.Text + "'", cnx);

                 int i = cmd.ExecuteNonQuery();
                 if (i != 0)
                  {
                   MessageBox.Show("modifier effectuée avec succes", "cbon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
             }

          
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                nomconjoint.Enabled = false;
                prenomconjoint.Enabled = false;
                nbrenf.Enabled = false;
            }
            else
            {
                nomconjoint.Enabled = true;
                prenomconjoint.Enabled = true;
                nbrenf.Enabled = true;
            }
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginpage log = new loginpage();
            log.Show();
        }
    }
}
