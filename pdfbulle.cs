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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf; 


namespace projet
{
    public partial class pdfbulle : Form
    {

        SqlConnection cnx = new SqlConnection(@"Data Source=LAPTOP-NJ81HHSQ\SQLSERVER;Initial Catalog=dbdd;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable Table = new DataTable();
        public void deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

        }
        public void remplirGrid(String id)
        {
            deconnecter();
            cnx.Open();
            cmd = new SqlCommand("SELECT  bulletin.bulletinNum as ID ,CONVERT(varchar,bulletin.dateDepot,10) as 'Date de depot',bulletin.acte as 'Acte',bulletin.frais as 'Frais demandés',bulletin.idEmp as 'Id Employé',concat(employee.nomEmp,' ',employee.prenomEmp) as 'Nom et Prénom' from bulletin,employee where employee.idEmp=bulletin.idEmp and bulletin.idEmp = '" + id + "'", cnx);
            Reader = cmd.ExecuteReader();
            Table.Load(Reader);
            dataGridView1.DataSource = Table;
            cnx.Close();

        }
        public void exportgridtopdf(DataGridView dgw, String filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add Header
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //add data row
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";

            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }

        }
        public pdfbulle(string str_value)
        {   
            InitializeComponent();
            remplirGrid(str_value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           exportgridtopdf(dataGridView1, "ListeBulletin");
        }
    }
}
