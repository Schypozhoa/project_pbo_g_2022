namespace ProjectPBO
{
    partial class f_TambahTrans
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
            this.cb_NamaBarang = new System.Windows.Forms.ComboBox();
            this.tb_Jumlah = new System.Windows.Forms.TextBox();
            this.lb_Barang = new System.Windows.Forms.Label();
            this.lb_Jumlah = new System.Windows.Forms.Label();
            this.btn_TambahTransaksi = new System.Windows.Forms.Button();
            this.btn_TambahBarang = new System.Windows.Forms.Button();
            this.tb_Keterangan = new System.Windows.Forms.TextBox();
            this.lb_Keterangan = new System.Windows.Forms.Label();
            this.lb_ListBarang = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dataPembelian = new System.Windows.Forms.DataGridView();
            this.lb_TotalHarga = new System.Windows.Forms.Label();
            this.lb_HargaHolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_NamaBarang
            // 
            this.cb_NamaBarang.FormattingEnabled = true;
            this.cb_NamaBarang.Location = new System.Drawing.Point(611, 36);
            this.cb_NamaBarang.Name = "cb_NamaBarang";
            this.cb_NamaBarang.Size = new System.Drawing.Size(121, 23);
            this.cb_NamaBarang.TabIndex = 0;
            // 
            // tb_Jumlah
            // 
            this.tb_Jumlah.Location = new System.Drawing.Point(611, 65);
            this.tb_Jumlah.Name = "tb_Jumlah";
            this.tb_Jumlah.Size = new System.Drawing.Size(100, 23);
            this.tb_Jumlah.TabIndex = 1;
            // 
            // lb_Barang
            // 
            this.lb_Barang.AutoSize = true;
            this.lb_Barang.Location = new System.Drawing.Point(561, 39);
            this.lb_Barang.Name = "lb_Barang";
            this.lb_Barang.Size = new System.Drawing.Size(44, 15);
            this.lb_Barang.TabIndex = 2;
            this.lb_Barang.Text = "Barang";
            // 
            // lb_Jumlah
            // 
            this.lb_Jumlah.AutoSize = true;
            this.lb_Jumlah.Location = new System.Drawing.Point(561, 68);
            this.lb_Jumlah.Name = "lb_Jumlah";
            this.lb_Jumlah.Size = new System.Drawing.Size(45, 15);
            this.lb_Jumlah.TabIndex = 3;
            this.lb_Jumlah.Text = "Jumlah";
            // 
            // btn_TambahTransaksi
            // 
            this.btn_TambahTransaksi.Location = new System.Drawing.Point(599, 403);
            this.btn_TambahTransaksi.Name = "btn_TambahTransaksi";
            this.btn_TambahTransaksi.Size = new System.Drawing.Size(108, 23);
            this.btn_TambahTransaksi.TabIndex = 4;
            this.btn_TambahTransaksi.Text = "Simpan Transaksi";
            this.btn_TambahTransaksi.UseVisualStyleBackColor = true;
            this.btn_TambahTransaksi.Click += new System.EventHandler(this.btn_TambahTransaksi_Click);
            // 
            // btn_TambahBarang
            // 
            this.btn_TambahBarang.Location = new System.Drawing.Point(611, 94);
            this.btn_TambahBarang.Name = "btn_TambahBarang";
            this.btn_TambahBarang.Size = new System.Drawing.Size(108, 23);
            this.btn_TambahBarang.TabIndex = 5;
            this.btn_TambahBarang.Text = "Tambah Barang";
            this.btn_TambahBarang.UseVisualStyleBackColor = true;
            this.btn_TambahBarang.Click += new System.EventHandler(this.btn_TambahBarang_Click);
            // 
            // tb_Keterangan
            // 
            this.tb_Keterangan.Location = new System.Drawing.Point(584, 332);
            this.tb_Keterangan.Multiline = true;
            this.tb_Keterangan.Name = "tb_Keterangan";
            this.tb_Keterangan.Size = new System.Drawing.Size(136, 65);
            this.tb_Keterangan.TabIndex = 6;
            // 
            // lb_Keterangan
            // 
            this.lb_Keterangan.AutoSize = true;
            this.lb_Keterangan.Location = new System.Drawing.Point(584, 314);
            this.lb_Keterangan.Name = "lb_Keterangan";
            this.lb_Keterangan.Size = new System.Drawing.Size(67, 15);
            this.lb_Keterangan.TabIndex = 7;
            this.lb_Keterangan.Text = "Keterangan";
            // 
            // lb_ListBarang
            // 
            this.lb_ListBarang.AutoSize = true;
            this.lb_ListBarang.Location = new System.Drawing.Point(30, 24);
            this.lb_ListBarang.Name = "lb_ListBarang";
            this.lb_ListBarang.Size = new System.Drawing.Size(130, 15);
            this.lb_ListBarang.TabIndex = 9;
            this.lb_ListBarang.Text = "Barang dalam Transaksi";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(30, 403);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataPembelian
            // 
            this.dataPembelian.AllowUserToAddRows = false;
            this.dataPembelian.AllowUserToDeleteRows = false;
            this.dataPembelian.AllowUserToResizeColumns = false;
            this.dataPembelian.AllowUserToResizeRows = false;
            this.dataPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPembelian.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataPembelian.Location = new System.Drawing.Point(30, 42);
            this.dataPembelian.MultiSelect = false;
            this.dataPembelian.Name = "dataPembelian";
            this.dataPembelian.ReadOnly = true;
            this.dataPembelian.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPembelian.RowTemplate.Height = 25;
            this.dataPembelian.Size = new System.Drawing.Size(349, 312);
            this.dataPembelian.TabIndex = 11;
            // 
            // lb_TotalHarga
            // 
            this.lb_TotalHarga.AutoSize = true;
            this.lb_TotalHarga.Location = new System.Drawing.Point(561, 168);
            this.lb_TotalHarga.Name = "lb_TotalHarga";
            this.lb_TotalHarga.Size = new System.Drawing.Size(67, 15);
            this.lb_TotalHarga.TabIndex = 12;
            this.lb_TotalHarga.Text = "Total Harga";
            // 
            // lb_HargaHolder
            // 
            this.lb_HargaHolder.AutoSize = true;
            this.lb_HargaHolder.Location = new System.Drawing.Point(561, 194);
            this.lb_HargaHolder.Name = "lb_HargaHolder";
            this.lb_HargaHolder.Size = new System.Drawing.Size(71, 15);
            this.lb_HargaHolder.TabIndex = 13;
            this.lb_HargaHolder.Text = "hargaholder";
            // 
            // f_TambahTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_HargaHolder);
            this.Controls.Add(this.lb_TotalHarga);
            this.Controls.Add(this.dataPembelian);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lb_ListBarang);
            this.Controls.Add(this.lb_Keterangan);
            this.Controls.Add(this.tb_Keterangan);
            this.Controls.Add(this.btn_TambahBarang);
            this.Controls.Add(this.btn_TambahTransaksi);
            this.Controls.Add(this.lb_Jumlah);
            this.Controls.Add(this.lb_Barang);
            this.Controls.Add(this.tb_Jumlah);
            this.Controls.Add(this.cb_NamaBarang);
            this.Name = "f_TambahTrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.f_TambahTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_NamaBarang;
        private System.Windows.Forms.TextBox tb_Jumlah;
        private System.Windows.Forms.Label lb_Barang;
        private System.Windows.Forms.Label lb_Jumlah;
        private System.Windows.Forms.Button btn_TambahTransaksi;
        private System.Windows.Forms.Button btn_TambahBarang;
        private System.Windows.Forms.TextBox tb_Keterangan;
        private System.Windows.Forms.Label lb_Keterangan;
        private System.Windows.Forms.Label lb_ListBarang;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dataPembelian;
        private System.Windows.Forms.Label lb_TotalHarga;
        private System.Windows.Forms.Label lb_HargaHolder;
    }
}