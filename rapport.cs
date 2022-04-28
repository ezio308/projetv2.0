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
    public partial class rapport : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        SqlDataReader Reader;
        public rapport(string login , string ddepot)
        {
            InitializeComponent();

            remplissage(login,ddepot);
        }
        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        public void remplissage(string login, string f)
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from users where login='" + login + "'", cnx);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            nom.Text = Convert.ToString(Reader["name"]);
            plafond.Text = Convert.ToString(Reader["plafond"]);
            cnx.Close();
           
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from bulletins where login='" + login + "'and datedepot='"+f+"'", cnx);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            frais.Text = Convert.ToString(Reader["actefrais"]);
            double remb = double.Parse(frais.Text);// frais
            double rembb = (double)(remb * 0.3);// 30%
            frais2.Text = Convert.ToString(rembb);
            double p2 = double.Parse(plafond.Text) - rembb;
            double pl = double.Parse(plafond.Text);//plafond
            plafond2.Text = Convert.ToString(p2);
            string reponse= Convert.ToString(Reader["reponse"]);
            double d = Convert.ToDouble(Reader["rembou"]);

            if (reponse.Equals("refuser"))
            {
                accept.Text = "Monsieur vous avez depassé votre plafonfVotre demande de remeboursement a éte refusé";
            }
            else if (reponse.Equals("accepter"))
            {

                accept.Text = "Votre demande de remeboursement a éte accepté ";
            }
            if(reponse.Equals("accepter")&&(d<rembb))
            {
                accept.Text = "Monsieur vous avez depassé votre plafonf on a accepté juste ce montant  " + d.ToString();

            }
            cnx.Close();
          


        }
        private void rapport_Load(object sender, EventArgs e)
        {

        }

        private void frais2_TextChanged(object sender, EventArgs e)
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
