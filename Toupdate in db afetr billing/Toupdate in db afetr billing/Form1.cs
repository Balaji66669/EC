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

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace Toupdate_in_db_afetr_billing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'availableDataSet.inven' table. You can move, or remove it, as needed.
            this.invenTableAdapter.Fill(this.availableDataSet.inven);

        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-4k1pjg0;Initial Catalog=available;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand command = new SqlCommand(@"update [inven] set [qty] = [qty] - '" + textBox2.Text + "' where [P_ID] = '" + textBox1.Text + "'", con);
            //SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            Form1_Load(sender, e);
            MessageBox.Show("updated");

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(@"D:\bills\  " + textBox3.Text +".xlxs  ", FileMode.Create));
           
            /*SaveFileDialog svg = new SaveFileDialog();
            svg.ShowDialog();

            using (FileStream stream = new FileStream(svg.FileName + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10, 10, 35, 45);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
               //////////// PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Test.pdf", FileMode.Create));
                /*Paragraph paragraph = new Paragraph("lol we created again and again");
                doc.Add(paragraph);*/

            doc.Open();
            
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
                }


                table.HeaderRows = 1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (dataGridView1[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                        }
                    }

                }
                //doc.Add(table);
                
                doc.Add(table);
                doc.Close();
            MessageBox.Show("Created Table");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }
    }
    }

