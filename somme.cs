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
    public partial class somme : Form
    {

        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        public somme()
        {
            InitializeComponent();
            fillcombo();
        }
        public void fillcombo()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select DISTINCT (YEAR(datedepot)) from bulletins ", cnx);
            Reader = cmd.ExecuteReader();
            if (Reader.HasRows)
            {

                while (Reader.Read())
                {
                    String d = Convert.ToString(Reader[0]);
                    annee.Items.Add(d);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();
            int veriff = 1;
            if (annee.SelectedIndex == -1)
            {
                veriff = 0;
            }
          
            else    
            {            
                           
                cmd = new SqlCommand("select SUM(rembou) from bulletins where datedepot LIKE'"+ this.annee.GetItemText(this.annee.SelectedItem) + "%'and reponse='accepter'", cnx);
                Reader = cmd.ExecuteReader();
                Reader.Read();
                double somme = Convert.ToDouble(Reader[0]);
                s.Text = Convert.ToString(somme);


                s.Text= Convert.ToString(somme);
            }

            if (veriff == 0)
            {
                MessageBox.Show("veuillez remplir tous les champs", "resseyez", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

       

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void annee_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
