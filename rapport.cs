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
        public void remplissage(string id, string f)
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from users where login='" + id + "'", cnx);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            nom.Text = Convert.ToString(Reader["name"]);
            plafond.Text = Convert.ToString(Reader["plafond"]);
            frais.Text = f;
            float remb = float.Parse(f);// frais
            float rembb = (float)(remb * 0.3);// 30%
            frais2.Text = Convert.ToString(rembb);
            double p2 = double.Parse(plafond.Text) - rembb;//plafond- 30%
            double pl = double.Parse(plafond.Text);//plafond
            plafond2.Text = Convert.ToString(p2);
            cnx.Close();
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from bulletins where login='" + id + "' and datedepot='"+f+"' ", cnx);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            int reponse= Convert.ToInt32(Reader["reponse"]);         
            if (reponse == 0)
            {
                accept.Text = "refuser";
            }
            else if (reponse == 1)
            {
                accept.Text = "accept"+pl;
                cmd1 = new SqlCommand("update users set plafond='" + 0 + "'  where login='" + id + "'", cnx);
                cmd1.ExecuteNonQuery();


            }
            else
            {
                accept.Text = "accept";

            }
          


        }
        private void rapport_Load(object sender, EventArgs e)
        {

        }
    }
}
