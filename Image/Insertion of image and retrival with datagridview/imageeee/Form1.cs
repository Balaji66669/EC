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

namespace imageeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=desktop-4k1pjg0;Initial Catalog=image;Integrated Security=True");
        
        

        byte[] imagebt = null;
        private void imagebutton_Click(object sender, EventArgs e)
        {
            //con.Open();
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picpath = dlg.FileName.ToString();
                textbox_image_path.Text = picpath;
                pictureBox1.ImageLocation = picpath;    
            }
            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            /*FileStream fstream = new FileStream(this.textbox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imagebt = br.ReadBytes((int)fstream.Length);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {


            FileStream fstream = new FileStream(this.textbox_image_path.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imagebt = br.ReadBytes((int)fstream.Length);
            try
            {
                con.Open();
                string query = @"INSERT INTO [image].[dbo].[ima] ([imag],[imageid],[img_path])  VALUES ( @img ,'" + textBox1.Text+ "','" + textbox_image_path.Text + "')";
                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.Add(new SqlParameter("@img", imagebt));
                command.ExecuteNonQuery();
                MessageBox.Show("Inserted");
               con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imageDataSet.ima' table. You can move, or remove it, as needed.
            this.imaTableAdapter.Fill(this.imageDataSet.ima);

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter myDataAdapter = new SqlDataAdapter();

                SqlCommand comm = new SqlCommand();
                comm = new SqlCommand("Select imag from [image].[dbo].[ima] where [imageid]='" + textBox1.Text + "'", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(myDataAdapter);
                SqlDataReader myreader = comm.ExecuteReader();
                myreader.Read();


                byte[] imgg = (byte[])(myreader["imag"]);
                if (imgg == null)
                {
                    pictureBox2.Image = null;
                }

                else
                {
                    MemoryStream mstream = new MemoryStream(imgg);
                    pictureBox2.Image = Image.FromStream(mstream);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 o = new Form2();
            o.Show();
        }
    }
}
