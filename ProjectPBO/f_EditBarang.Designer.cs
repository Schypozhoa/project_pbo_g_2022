namespace ProjectPBO
{
    partial class f_EditBarang
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_UbahBarang = new System.Windows.Forms.Button();
            this.lb_JenisBarang = new System.Windows.Forms.Label();
            this.cb_JenisBarang = new System.Windows.Forms.ComboBox();
            this.tb_HargaBarang = new System.Windows.Forms.TextBox();
            this.lb_hargaBarang = new System.Windows.Forms.Label();
            this.lb_namaBarang = new System.Windows.Forms.Label();
            this.cb_NamaBarang = new System.Windows.Forms.ComboBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.tb_NamaBarang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(331, 289);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(85, 23);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_UbahBarang
            // 
            this.btn_UbahBarang.Location = new System.Drawing.Point(422, 289);
            this.btn_UbahBarang.Name = "btn_UbahBarang";
            this.btn_UbahBarang.Size = new System.Drawing.Size(85, 23);
            this.btn_UbahBarang.TabIndex = 15;
            this.btn_UbahBarang.Text = "Simpan";
            this.btn_UbahBarang.UseVisualStyleBackColor = true;
            this.btn_UbahBarang.Click += new System.EventHandler(this.btn_UbahBarang_Click);
            // 
            // lb_JenisBarang
            // 
            this.lb_JenisBarang.AutoSize = true;
            this.lb_JenisBarang.Location = new System.Drawing.Point(293, 200);
            this.lb_JenisBarang.Name = "lb_JenisBarang";
            this.lb_JenisBarang.Size = new System.Drawing.Size(32, 15);
            this.lb_JenisBarang.TabIndex = 14;
            this.lb_JenisBarang.Text = "Jenis";
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
            this.cb_JenisBarang.Location = new System.Drawing.Point(338, 197);
            this.cb_JenisBarang.Name = "cb_JenisBarang";
            this.cb_JenisBarang.Size = new System.Drawing.Size(121, 23);
            this.cb_JenisBarang.TabIndex = 13;
            // 
            // tb_HargaBarang
            // 
            this.tb_HargaBarang.Location = new System.Drawing.Point(338, 168);
            this.tb_HargaBarang.Name = "tb_HargaBarang";
            this.tb_HargaBarang.Size = new System.Drawing.Size(100, 23);
            this.tb_HargaBarang.TabIndex = 12;
            // 
            // lb_hargaBarang
            // 
            this.lb_hargaBarang.AutoSize = true;
            this.lb_hargaBarang.Location = new System.Drawing.Point(293, 171);
            this.lb_hargaBarang.Name = "lb_hargaBarang";
            this.lb_hargaBarang.Size = new System.Drawing.Size(39, 15);
            this.lb_hargaBarang.TabIndex = 11;
            this.lb_hargaBarang.Text = "Harga";
            // 
            // lb_namaBarang
            // 
            this.lb_namaBarang.AutoSize = true;
            this.lb_namaBarang.Location = new System.Drawing.Point(293, 143);
            this.lb_namaBarang.Name = "lb_namaBarang";
            this.lb_namaBarang.Size = new System.Drawing.Size(39, 15);
            this.lb_namaBarang.TabIndex = 10;
            this.lb_namaBarang.Text = "Nama";
            // 
            // cb_NamaBarang
            // 
            this.cb_NamaBarang.FormattingEnabled = true;
            this.cb_NamaBarang.Location = new System.Drawing.Point(338, 38);
            this.cb_NamaBarang.Name = "cb_NamaBarang";
            this.cb_NamaBarang.Size = new System.Drawing.Size(121, 23);
            this.cb_NamaBarang.TabIndex = 18;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(331, 20);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(143, 15);
            this.lb_Title.TabIndex = 19;
            this.lb_Title.Text = "Barang yang ingin diubah";
            // 
            // tb_NamaBarang
            // 
            this.tb_NamaBarang.Location = new System.Drawing.Point(338, 139);
            this.tb_NamaBarang.Name = "tb_NamaBarang";
            this.tb_NamaBarang.Size = new System.Drawing.Size(100, 23);
            this.tb_NamaBarang.TabIndex = 20;
            // 
            // f_EditBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_NamaBarang);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.cb_NamaBarang);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_UbahBarang);
            this.Controls.Add(this.lb_JenisBarang);
            this.Controls.Add(this.cb_JenisBarang);
            this.Controls.Add(this.tb_HargaBarang);
            this.Controls.Add(this.lb_hargaBarang);
            this.Controls.Add(this.lb_namaBarang);
            this.Name = "f_EditBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.f_EditBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_UbahBarang;
        private System.Windows.Forms.Label lb_JenisBarang;
        private System.Windows.Forms.ComboBox cb_JenisBarang;
        private System.Windows.Forms.TextBox tb_HargaBarang;
        private System.Windows.Forms.Label lb_hargaBarang;
        private System.Windows.Forms.Label lb_namaBarang;
        private System.Windows.Forms.ComboBox cb_NamaBarang;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox tb_NamaBarang;
    }
}