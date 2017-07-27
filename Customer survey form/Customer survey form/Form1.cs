using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Customer_survey_form
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=desktop-4k1pjg0\sqlexpress;Initial Catalog=survey;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("insert into customer (name,DOB,e_mail,contact,password,country,state,street,door_no,pincode,aadhar )values (@name,@DOB,@e_mail,@contact,@password,@country,@state,@street,@door_no,@pincode,@aadhar)", con);
            cmd.Parameters.Add("@name", textBox1.Text);
            cmd.Parameters.Add("@DOB", textBox3.Text);
            cmd.Parameters.Add("@e_mail", textBox4.Text);
            cmd.Parameters.Add("@contact", textBox5.Text);
            cmd.Parameters.Add("@password", textBox6.Text);
            cmd.Parameters.Add("@country", textBox7.Text);
            cmd.Parameters.Add("@state", textBox8.Text);
            cmd.Parameters.Add("@street", textBox2.Text);
            cmd.Parameters.Add("@door_no", textBox9.Text);
            cmd.Parameters.Add("@pincode", textBox10.Text);
            cmd.Parameters.Add("@aadhar", textBox11.Text);

            cmd.ExecuteNonQuery();




        }  


    }
}
