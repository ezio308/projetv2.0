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
    public partial class verification : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand(); 
        SqlCommand cmd3 = new SqlCommand();
        SqlCommand cmd4 = new SqlCommand();
        SqlCommand cmd5 = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();

        public verification(string frais, string id,string bull, string date,string nom)
        {
            InitializeComponent();
            remplissage(id,frais,bull,date);
            textBox2.Text = nom;
            textBox1.Text = date;
        }
        public void remplissage(string id , string f,string bull,string date)
        {
            
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("select * from users where login='" + id + "'", cnx);

            Reader = cmd.ExecuteReader();
            Reader.Read();
            nom.Text = Convert.ToString(Reader["name"]);
            plafond.Text = Convert.ToString(Reader["plafond"]);
            frais.Text = f;
            double remb =   double.Parse(f);//
            double rembb = (remb * 30)/100;// 30%
            double pp = double.Parse(plafond.Text);
            frais2.Text = Convert.ToString(rembb);
            double p2 = pp-rembb;//plafond- 30%
            double pl = double.Parse(plafond.Text);//plafond
            plafond2.Text = Convert.ToString(p2);
            cnx.Close();
            Deconnecter();
            cnx.Open();
        
            if (pl == 0)
            {
                cmd = new SqlCommand("update bulletins set reponse= 'refuser'  where  NUMBULL='" + bull + "'", cnx);
                cmd2 = new SqlCommand("update bulletins set rembou='"+0+"'  where  NUMBULL='" + bull + "'", cnx);
                cmd2.ExecuteNonQuery();
            }
            else if (p2 >= 0)
            {
                cmd = new SqlCommand("update bulletins set reponse='accepter'  where  NUMBULL='"+bull+"'", cnx);
                cmd1 = new SqlCommand("update users set plafond='" + p2 + "'  where login='" + id + "'", cnx);
                cmd2 = new SqlCommand("update bulletins set rembou='"+rembb+"'  where  NUMBULL='" + bull + "'", cnx);
                cmd2.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();  
            }
            else if (p2<0)
            { 
                cmd = new SqlCommand("update bulletins set reponse='accepter'  where  NUMBULL='" + bull + "'", cnx);
                cmd1 = new SqlCommand("update users set plafond='" + 0 + "'  where login='" + id + "'", cnx);
                cmd2 = new SqlCommand("update bulletins set rembou='" + rembb + "'  where  NUMBULL='" + bull + "'", cnx);
                cmd1.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
            }
            cmd.ExecuteNonQuery();
            cnx.Close();
            

        }
        public void Deconnecter()//ay bd ma7loula tssakerha//
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        private void verification_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pagePrecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saisie sai = new saisie(textBox2.Text);
            sai.Show();
            this.Hide();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginpage sais = new loginpage();
            sais.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void plafond_TextChanged(object sender, EventArgs e)
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
