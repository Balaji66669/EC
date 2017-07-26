using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace imageeee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            

        }
        DataTable dt = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=desktop-4k1pjg0;Initial Catalog=image;Integrated Security=True");
            try
            { 
            string qry = "select * from ima";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = 200;
                }

                DataGridViewImageColumn image = new DataGridViewImageColumn();
                image = (DataGridViewImageColumn)dataGridView1.Columns[0];
                image.ImageLayout = DataGridViewImageCellLayout.Stretch;
                da.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            DataView DV = new DataView(dt); // dataadapter ,connectoin,cmd with selectg command,dataview,datatable
      
            DV.RowFilter = string.Format("imageid LIKE '{0}%'", textBox1.Text);
            
            dataGridView1.DataSource = DV;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 200;
            }

            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image = (DataGridViewImageColumn)dataGridView1.Columns[0];
            image.ImageLayout = DataGridViewImageCellLayout.Stretch;
           
        }
    }
}
