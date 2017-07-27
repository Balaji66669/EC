using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.IO;
using System.Diagnostics;


namespace progressbaranddate
{      
    public partial class Form1 : Form
    {      // static int j;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
           

        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-4k1pjg0;Initial Catalog=dates;Integrated Security=True");
        //int i = new int();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datesDataSet4.datetime' table. You can move, or remove it, as needed.
            this.datetimeTableAdapter.Fill(this.datesDataSet4.datetime);
            // TODO: This line of code loads data into the 'datesDataSet.date' table. You can move, or remove it, as needed.
            this.dateTableAdapter.Fill(this.datesDataSet.date);
           
            //do nothing
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            DateTime datetime = DateTime.Now;
            timerLabel.Text = datetime.ToString();
            textBox2.Text = datetime.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // this.textBox1.Text = dateTimePicker1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = dateTimePicker1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //do nothing
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //this.textBox1.Text = dateTimePicker1.Text;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //do nothing
        }

        private void dateTimePicker1_CursorChanged(object sender, EventArgs e)
        {
            //do nothing
        }

        private void insert_Click(object sender, EventArgs e)
        {   try
            {
                con.Open();
                string query = @"INSERT INTO [dates].[dbo].[date] ([date]) VALUES ('" +this.timerLabel.Text+ "' )";
               // string query1 = @"INSERT INTO [dates].[dbo].[datetime] ([datetime]) VALUES ('" + this.timerLabel.Text + "' )";
                SqlCommand command = new SqlCommand(query, con);
               // SqlCommand com = new SqlCommand(query1, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Inserted date");
               // com.ExecuteNonQuery();
                //MessageBox.Show("Inserted date time");
                Form1_Load( sender, e);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
           /* j = ++j;
            if (j == 3)
            {
                Form2 f2 = new Form2();
                f2.Show();
                textBox2.Text = j.ToString();
                this.Hide();

            }
            else
            {
                textBox2.Text = j.ToString();
                MessageBox.Show(" less than 3");
            }  
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.ecretailsolutions.com/");
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
