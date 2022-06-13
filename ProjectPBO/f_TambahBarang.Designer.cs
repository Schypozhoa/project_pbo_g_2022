namespace ProjectPBO
{
    partial class f_TambahBarang
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
            this.lb_namaBarang = new System.Windows.Forms.Label();
            this.lb_hargaBarang = new System.Windows.Forms.Label();
            this.tb_HargaBarang = new System.Windows.Forms.TextBox();
            this.cb_JenisBarang = new System.Windows.Forms.ComboBox();
            this.lb_JenisBarang = new System.Windows.Forms.Label();
            this.btn_TambahBarang = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tb_NamaBarang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_namaBarang
            // 
            this.lb_namaBarang.AutoSize = true;
            this.lb_namaBarang.Location = new System.Drawing.Point(224, 91);
            this.lb_namaBarang.Name = "lb_namaBarang";
            this.lb_namaBarang.Size = new System.Drawing.Size(39, 15);
            this.lb_namaBarang.TabIndex = 1;
            this.lb_namaBarang.Text = "Nama";
            // 
            // lb_hargaBarang
            // 
            this.lb_hargaBarang.AutoSize = true;
            this.lb_hargaBarang.Location = new System.Drawing.Point(224, 119);
            this.lb_hargaBarang.Name = "lb_hargaBarang";
            this.lb_hargaBarang.Size = new System.Drawing.Size(39, 15);
            this.lb_hargaBarang.TabIndex = 2;
            this.lb_hargaBarang.Text = "Harga";
            // 
            // tb_HargaBarang
            // 
            this.tb_HargaBarang.Location = new System.Drawing.Point(269, 116);
            this.tb_HargaBarang.Name = "tb_HargaBarang";
            this.tb_HargaBarang.Size = new System.Drawing.Size(100, 23);
            this.tb_HargaBarang.TabIndex = 3;
            // 
            // cb_JenisBarang
            // 
            this.cb_JenisBarang.FormattingEnabled = true;
            this.cb_JenisBarang.Items.AddRange(new object[] {
            "Makanan/Minuman",
            "Sembako",
            "Elektronik",
            "Obat-obatan",
            "Lain lain"});
            this.cb_JenisBarang.Location = new System.Drawing.Point(269, 145);
            this.cb_JenisBarang.Name = "cb_JenisBarang";
            this.cb_JenisBarang.Size = new System.Drawing.Size(121, 23);
            this.cb_JenisBarang.TabIndex = 5;
            // 
            // lb_JenisBarang
            // 
            this.lb_JenisBarang.AutoSize = true;
            this.lb_JenisBarang.Location = new System.Drawing.Point(224, 148);
            this.lb_JenisBarang.Name = "lb_JenisBarang";
            this.lb_JenisBarang.Size = new System.Drawing.Size(32, 15);
            this.lb_JenisBarang.TabIndex = 6;
            this.lb_JenisBarang.Text = "Jenis";
            // 
            // btn_TambahBarang
            // 
            this.btn_TambahBarang.Location = new System.Drawing.Point(353, 237);
            this.btn_TambahBarang.Name = "btn_TambahBarang";
            this.btn_TambahBarang.Size = new System.Drawing.Size(85, 23);
            this.btn_TambahBarang.TabIndex = 7;
            this.btn_TambahBarang.Text = "Tambahkan";
            this.btn_TambahBarang.UseVisualStyleBackColor = true;
            this.btn_TambahBarang.Click += new System.EventHandler(this.btn_TambahBarang_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(262, 237);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(85, 23);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tb_NamaBarang
            // 
            this.tb_NamaBarang.Location = new System.Drawing.Point(269, 87);
            this.tb_NamaBarang.Name = "tb_NamaBarang";
            this.tb_NamaBarang.Size = new System.Drawing.Size(100, 23);
            this.tb_NamaBarang.TabIndex = 9;
            // 
            // f_TambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_NamaBarang);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_TambahBarang);
            this.Controls.Add(this.lb_JenisBarang);
            this.Controls.Add(this.cb_JenisBarang);
            this.Controls.Add(this.tb_HargaBarang);
            this.Controls.Add(this.lb_hargaBarang);
            this.Controls.Add(this.lb_namaBarang);
            this.Name = "f_TambahBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_namaBarang;
        private System.Windows.Forms.Label lb_hargaBarang;
        private System.Windows.Forms.TextBox tb_HargaBarang;
        private System.Windows.Forms.ComboBox cb_JenisBarang;
        private System.Windows.Forms.Label lb_JenisBarang;
        private System.Windows.Forms.Button btn_TambahBarang;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tb_NamaBarang;
    }
}