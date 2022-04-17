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
            int veriff = 1;

            MessageBox.Show(date.SelectedIndex.ToString(), "resseyez", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (date.SelectedIndex == -1)
            {
                veriff = 0;
                MessageBox.Show("loula", "resseyez", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((date.SelectedIndex == 1) && (annee.SelectedIndex == -1))
            {
                veriff = 0;
            }
            else if ((date.SelectedIndex == 0) && (mois.SelectedIndex == -1))
            {
                veriff = 0;
            }
            else    
            {
                if (annee.SelectedIndex != -1)
                {
                    string selected = this.annee.GetItemText(this.annee.SelectedItem);
                    MessageBox.Show(selected);
                }
                else {
                    string selected = this.mois.GetItemText(this.mois.SelectedItem);
                }


                int somme = 0;
                Deconnecter();
                cnx.Open();
                cmd = new SqlCommand("select * from users ", cnx);
                Reader = cmd.ExecuteReader();
                if (Reader.HasRows)
                {

                    while (Reader.Read())
                    {
                        int plafond = Convert.ToInt32(Reader["plafond"]);
                        int grade = Convert.ToInt32(Reader["grade"]);
                        if (grade==1)
                         {
                            somme = somme + (1800 - plafond);
                         }
                        else if (grade == 2)
                        {
                            somme = somme + (1400 - plafond);
                        }
                        else if (grade == 3)
                        { 
                            somme = somme + (1000 - plafond);
                        }
                       else
                        {
                            somme = somme + (600 - plafond);
                        }
                    }
                }
                
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

        private void somme_Load(object sender, EventArgs e)
        {
            annee.Enabled = false;
            mois.Enabled = false;
        }

        private void date_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (date.SelectedIndex == 1)
            {
                annee.Enabled = true;
                mois.Enabled = false;
            }
            if (date.SelectedIndex == 0)
            {
                mois.Enabled = true;
                annee.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
