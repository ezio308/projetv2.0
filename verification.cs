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

        public verification(string frais, string id,string bull, string date)
        {
            InitializeComponent();
            remplissage(id,frais,bull,date);
        }
        public void remplissage(string id , string f,string bull,string date)
        {
            SqlCommand cmd1 = new SqlCommand();
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("select count(*) from bulletins where login='" + id + "'and datedepot='"+DateTime.Now+"'", cnx);
            Reader = cmd.ExecuteReader();
            Reader.Read();


            if (!Reader.HasRows)
            {
                cmd2 = new SqlCommand("update users set plafond='" + 1800 + "'  where login='" + id + "' and grade='"+1+"'", cnx);
                cmd3 = new SqlCommand("update users set plafond='" + 1400 + "'  where login='" + id + "' and grade='" + 2 + "'", cnx);
                cmd4 = new SqlCommand("update users set plafond='" + 1000 + "'  where login='" + id + "' and grade='" + 3 + "'", cnx);
                cmd5= new SqlCommand("update users set plafond='" + 600 + "'  where login='" + id + "' and grade='" + 4 + "'", cnx);
            }
           
            cnx.Close();
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("select * from users where login='" + id + "'", cnx);

            Reader = cmd.ExecuteReader();
            Reader.Read();
            nom.Text = Convert.ToString(Reader["name"]);
            plafond.Text = Convert.ToString(Reader["plafond"]);
            frais.Text = f;
            double remb = double.Parse(f);// frais
            double rembb = remb * 0.3;// 30%
            frais2.Text = Convert.ToString(rembb);
            double p2 = double.Parse(plafond.Text)-rembb;//plafond- 30%
            double pl = double.Parse(plafond.Text);//plafond
            plafond2.Text = Convert.ToString(p2);
            cnx.Close();
            Deconnecter();
            cnx.Open();
        
            if (pl == 0)
            {
                cmd = new SqlCommand("update bulletins set reponse= ' refusé '  where login='" + id + "'and datedepot='"+ date + "'and NUMBULL='" + bull + "'", cnx);

            }
            else if (p2 >= 0)
            {
                cmd = new SqlCommand("update bulletins set reponse=' accepté '  where login='" + id + "'and datedepot='" + date+ "'and NUMBULL='"+bull+"'", cnx);
                cmd1 = new SqlCommand("update users set plafond='" + p2 + "'  where login='" + id + "'", cnx);
                cmd1.ExecuteNonQuery();  
            }
            else if (p2<0)
            { 
                cmd = new SqlCommand("update bulletins set reponse=' accepté '  where login='" + id + "'and datedepot='" + date + "'and NUMBULL='" + bull + "'", cnx);
                cmd1 = new SqlCommand("update users set plafond='" + p2 + "'  where login='" + id + "'", cnx);

                cmd1.ExecuteNonQuery();
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
    }
}
