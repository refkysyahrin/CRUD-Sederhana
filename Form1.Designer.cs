namespace CRUD_Sederhanaa
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.Tambah = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.Ubah = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "NIM";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Telepon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Alamat";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(114, 40);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(114, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(114, 124);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(114, 163);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(114, 200);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 9;
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(276, 47);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(75, 23);
            this.Tambah.TabIndex = 10;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.BtnTambah);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(276, 84);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(75, 23);
            this.Hapus.TabIndex = 11;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.BtnHapus);
            // 
            // Ubah
            // 
            this.Ubah.Location = new System.Drawing.Point(276, 124);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(75, 23);
            this.Ubah.TabIndex = 12;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseVisualStyleBackColor = true;
            this.Ubah.Click += new System.EventHandler(this.button6_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(276, 163);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 13;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.BtnRefresh);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(527, 420);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Ubah);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telepon;
        private System.Windows.Forms.Label Alamat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Button Ubah;
        private System.Windows.Forms.Button Refresh;
    }
}

