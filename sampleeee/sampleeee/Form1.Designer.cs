namespace sampleeee
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.load_button = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.P_Id_text = new System.Windows.Forms.TextBox();
            this.P_Name_text = new System.Windows.Forms.TextBox();
            this.P_Name_label = new System.Windows.Forms.Label();
            this.P_Id_label = new System.Windows.Forms.Label();
            this.insert_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.update_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qr_button = new System.Windows.Forms.Button();
            this.barcode_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sampleDataSet = new sampleeee.SampleDataSet();
            this.sampletableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sample_tableTableAdapter = new sampleeee.SampleDataSetTableAdapters.sample_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampletableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(466, 299);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(75, 23);
            this.load_button.TabIndex = 1;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(739, 40);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 2;
            this.search.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // P_Id_text
            // 
            this.P_Id_text.Location = new System.Drawing.Point(125, 46);
            this.P_Id_text.Name = "P_Id_text";
            this.P_Id_text.Size = new System.Drawing.Size(100, 20);
            this.P_Id_text.TabIndex = 3;
            // 
            // P_Name_text
            // 
            this.P_Name_text.Location = new System.Drawing.Point(125, 73);
            this.P_Name_text.Name = "P_Name_text";
            this.P_Name_text.Size = new System.Drawing.Size(100, 20);
            this.P_Name_text.TabIndex = 4;
            // 
            // P_Name_label
            // 
            this.P_Name_label.Location = new System.Drawing.Point(12, 43);
            this.P_Name_label.Name = "P_Name_label";
            this.P_Name_label.Size = new System.Drawing.Size(100, 23);
            this.P_Name_label.TabIndex = 5;
            this.P_Name_label.Text = "Product Id";
            this.P_Name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P_Id_label
            // 
            this.P_Id_label.Location = new System.Drawing.Point(12, 69);
            this.P_Id_label.Name = "P_Id_label";
            this.P_Id_label.Size = new System.Drawing.Size(100, 23);
            this.P_Id_label.TabIndex = 6;
            this.P_Id_label.Text = "Product Name";
            this.P_Id_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(3, 233);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 7;
            this.insert_button.Text = "Insert ";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(106, 233);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 23);
            this.Next_button.TabIndex = 8;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(211, 233);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 9;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // update_text
            // 
            this.update_text.Location = new System.Drawing.Point(125, 99);
            this.update_text.Name = "update_text";
            this.update_text.Size = new System.Drawing.Size(100, 20);
            this.update_text.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "update name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(3, 285);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 12;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(211, 285);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 13;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(484, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 141);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // qr_button
            // 
            this.qr_button.Location = new System.Drawing.Point(386, 360);
            this.qr_button.Name = "qr_button";
            this.qr_button.Size = new System.Drawing.Size(75, 23);
            this.qr_button.TabIndex = 15;
            this.qr_button.Text = "Qr Code";
            this.qr_button.UseVisualStyleBackColor = true;
            this.qr_button.Click += new System.EventHandler(this.qr_button_Click);
            // 
            // barcode_button
            // 
            this.barcode_button.Location = new System.Drawing.Point(386, 412);
            this.barcode_button.Name = "barcode_button";
            this.barcode_button.Size = new System.Drawing.Size(75, 23);
            this.barcode_button.TabIndex = 16;
            this.barcode_button.Text = "Bar Code";
            this.barcode_button.UseVisualStyleBackColor = true;
            this.barcode_button.Click += new System.EventHandler(this.barcode_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(739, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(499, 380);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(917, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1078, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 46);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "search";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(845, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(372, 20);
            this.textBox2.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(845, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sampletableBindingSource;
            this.comboBox2.DisplayMember = "P_Id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(550, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // sampleDataSet
            // 
            this.sampleDataSet.DataSetName = "SampleDataSet";
            this.sampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampletableBindingSource
            // 
            this.sampletableBindingSource.DataMember = "sample_table";
            this.sampletableBindingSource.DataSource = this.sampleDataSet;
            // 
            // sample_tableTableAdapter
            // 
            this.sample_tableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 570);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.barcode_button);
            this.Controls.Add(this.qr_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_text);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.P_Id_label);
            this.Controls.Add(this.P_Name_label);
            this.Controls.Add(this.P_Name_text);
            this.Controls.Add(this.P_Id_text);
            this.Controls.Add(this.search);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampletableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.TextBox P_Id_text;
        private System.Windows.Forms.TextBox P_Name_text;
        private System.Windows.Forms.Label P_Name_label;
        private System.Windows.Forms.Label P_Id_label;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox update_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button qr_button;
        private System.Windows.Forms.Button barcode_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private SampleDataSet sampleDataSet;
        private System.Windows.Forms.BindingSource sampletableBindingSource;
        private SampleDataSetTableAdapters.sample_tableTableAdapter sample_tableTableAdapter;
    }
}

