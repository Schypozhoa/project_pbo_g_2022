namespace ProjectPBO
{
    partial class f_EditStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_EditStok));
            this.tb_StokBarang = new System.Windows.Forms.TextBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.cb_NamaBarang = new System.Windows.Forms.ComboBox();
            this.btn_UbahStok = new System.Windows.Forms.Button();
            this.lb_stokBarang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Transaksi = new System.Windows.Forms.Button();
            this.btn_Stok = new System.Windows.Forms.Button();
            this.btn_Barang = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_LihatStok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_StokBarang
            // 
            this.tb_StokBarang.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_StokBarang.Location = new System.Drawing.Point(515, 305);
            this.tb_StokBarang.Name = "tb_StokBarang";
            this.tb_StokBarang.Size = new System.Drawing.Size(170, 29);
            this.tb_StokBarang.TabIndex = 30;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lb_Title.Location = new System.Drawing.Point(457, 191);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(224, 21);
            this.lb_Title.TabIndex = 29;
            this.lb_Title.Text = "Pilih Barang yang Akan Diubah";
            // 
            // cb_NamaBarang
            // 
            this.cb_NamaBarang.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_NamaBarang.FormattingEnabled = true;
            this.cb_NamaBarang.Location = new System.Drawing.Point(461, 220);
            this.cb_NamaBarang.Name = "cb_NamaBarang";
            this.cb_NamaBarang.Size = new System.Drawing.Size(224, 29);
            this.cb_NamaBarang.TabIndex = 28;
            // 
            // btn_UbahStok
            // 
            this.btn_UbahStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UbahStok.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_UbahStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_UbahStok.Location = new System.Drawing.Point(457, 349);
            this.btn_UbahStok.Name = "btn_UbahStok";
            this.btn_UbahStok.Size = new System.Drawing.Size(228, 49);
            this.btn_UbahStok.TabIndex = 26;
            this.btn_UbahStok.Text = "Simpan";
            this.btn_UbahStok.UseVisualStyleBackColor = true;
            this.btn_UbahStok.Click += new System.EventHandler(this.btn_UbahStok_Click);
            // 
            // lb_stokBarang
            // 
            this.lb_stokBarang.AutoSize = true;
            this.lb_stokBarang.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_stokBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lb_stokBarang.Location = new System.Drawing.Point(457, 308);
            this.lb_stokBarang.Name = "lb_stokBarang";
            this.lb_stokBarang.Size = new System.Drawing.Size(40, 21);
            this.lb_stokBarang.TabIndex = 21;
            this.lb_stokBarang.Text = "Stok";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_Transaksi);
            this.panel1.Controls.Add(this.btn_Stok);
            this.panel1.Controls.Add(this.btn_Barang);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 31;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_exit.Location = new System.Drawing.Point(0, 535);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(186, 42);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Keluar";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(0, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 42);
            this.panel3.TabIndex = 5;
            // 
            // btn_Transaksi
            // 
            this.btn_Transaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Transaksi.FlatAppearance.BorderSize = 0;
            this.btn_Transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaksi.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Transaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Transaksi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Transaksi.Image")));
            this.btn_Transaksi.Location = new System.Drawing.Point(0, 270);
            this.btn_Transaksi.Name = "btn_Transaksi";
            this.btn_Transaksi.Size = new System.Drawing.Size(186, 42);
            this.btn_Transaksi.TabIndex = 3;
            this.btn_Transaksi.Text = "Transaksi";
            this.btn_Transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Transaksi.UseVisualStyleBackColor = true;
            this.btn_Transaksi.Click += new System.EventHandler(this.btn_Transaksi_Click);
            // 
            // btn_Stok
            // 
            this.btn_Stok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Stok.FlatAppearance.BorderSize = 0;
            this.btn_Stok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stok.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Stok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Stok.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stok.Image")));
            this.btn_Stok.Location = new System.Drawing.Point(0, 228);
            this.btn_Stok.Name = "btn_Stok";
            this.btn_Stok.Size = new System.Drawing.Size(186, 42);
            this.btn_Stok.TabIndex = 1;
            this.btn_Stok.Text = "Stok         ";
            this.btn_Stok.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Stok.UseVisualStyleBackColor = true;
            this.btn_Stok.Click += new System.EventHandler(this.btn_Stok_Click);
            // 
            // btn_Barang
            // 
            this.btn_Barang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Barang.FlatAppearance.BorderSize = 0;
            this.btn_Barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Barang.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Barang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_Barang.Image = ((System.Drawing.Image)(resources.GetObject("btn_Barang.Image")));
            this.btn_Barang.Location = new System.Drawing.Point(0, 186);
            this.btn_Barang.Name = "btn_Barang";
            this.btn_Barang.Size = new System.Drawing.Size(186, 42);
            this.btn_Barang.TabIndex = 2;
            this.btn_Barang.Text = "Barang      ";
            this.btn_Barang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Barang.UseVisualStyleBackColor = true;
            this.btn_Barang.Click += new System.EventHandler(this.btn_Barang_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(0, 144);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(186, 42);
            this.btn_home.TabIndex = 5;
            this.btn_home.Text = "Home       ";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lb_LihatStok
            // 
            this.lb_LihatStok.AutoSize = true;
            this.lb_LihatStok.Font = new System.Drawing.Font("Nirmala UI", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_LihatStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lb_LihatStok.Location = new System.Drawing.Point(344, 107);
            this.lb_LihatStok.Name = "lb_LihatStok";
            this.lb_LihatStok.Size = new System.Drawing.Size(450, 62);
            this.lb_LihatStok.TabIndex = 39;
            this.lb_LihatStok.Text = "UBAH PERSEDIAAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(457, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Masukkan Data Baru";
            // 
            // f_EditStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_LihatStok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_StokBarang);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.cb_NamaBarang);
            this.Controls.Add(this.btn_UbahStok);
            this.Controls.Add(this.lb_stokBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f_EditStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.f_EditStok_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_StokBarang;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.ComboBox cb_NamaBarang;
        private System.Windows.Forms.Button btn_UbahStok;
        private System.Windows.Forms.Label lb_stokBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Transaksi;
        private System.Windows.Forms.Button btn_Stok;
        private System.Windows.Forms.Button btn_Barang;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_LihatStok;
        private System.Windows.Forms.Label label1;
    }
}