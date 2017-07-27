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
using AForge.Video;
using ZXing;
using ZXing.QrCode;
using AForge.Video.DirectShow;

namespace sampleeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Image)eventArgs.Frame.Clone();
        }


        DataTable dbdataset;
        SqlConnection myConnection = new SqlConnection(@"Data Source=desktop-4k1pjg0;Initial Catalog=Sample;Integrated Security=True");

        public SqlConnection MyConnection { get => myConnection; set => myConnection = value; }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand mycmd = new SqlCommand(@"select * FROM [Sample].[dbo].[sample_table] order by P_Name ", myConnection);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = mycmd;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dbdataset;
                dataGridView1.DataSource = bsource;
                sda.Update(dbdataset);
                MessageBox.Show("Loaded");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset); // dataadapter ,connectoin,cmd with selectg command,dataview,datatable
            DV.RowFilter = string.Format("P_Id LIKE '{0}%'", search.Text);
            dataGridView1.DataSource = DV;
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                string query = @"INSERT INTO [Sample].[dbo].[sample_table] ([P_Id], [P_Name]) VALUES ('" + P_Id_text.Text + "', '" + P_Name_text.Text + "')";
                SqlCommand command = new SqlCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.Exit();
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                string query = @"update [sample_table] set [P_Name] = '" + update_text.Text + "' where [p_Id] = '" + P_Id_text.Text + "'  ";
                SqlCommand command = new SqlCommand(query, myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Open();
                string query = @"delete [sample_table]  where [p_Id] = '" + P_Id_text.Text + "'  ";
                SqlCommand command = new SqlCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Updated");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;


            // TODO: This line of code loads data into the 'sampleDataSet.sample_table' table. You can move, or remove it, as needed.
            this.sample_tableTableAdapter.Fill(this.sampleDataSet.sample_table);
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);

            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

        }
        private void qr_button_Click(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBox1.Image = qrcode.Draw(P_Id_text.Text, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void barcode_button_Click(object sender, EventArgs e)
        {
            try
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox1.Image = barcode.Draw(P_Id_text.Text, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            button1.Enabled = false;
            button2.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
            textBox2.Text = "";
            search.Text = "";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox2.Image);
            try
            {
                string decoded = result.ToString().Trim();
                textBox2.Text = decoded;
                search.Text = decoded;
                FinalFrame.Stop();

            }

            catch (Exception ex)
            {

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}









