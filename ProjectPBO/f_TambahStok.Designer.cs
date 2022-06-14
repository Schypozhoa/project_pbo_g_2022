namespace ProjectPBO
{
    partial class f_TambahStok
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
            this.tb_StokBarang = new System.Windows.Forms.TextBox();
            this.lb_namaBarang = new System.Windows.Forms.Label();
            this.cb_NamaBarang = new System.Windows.Forms.ComboBox();
            this.lb_stokBarang = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_TambahStok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_StokBarang
            // 
            this.tb_StokBarang.Location = new System.Drawing.Point(365, 237);
            this.tb_StokBarang.Name = "tb_StokBarang";
            this.tb_StokBarang.Size = new System.Drawing.Size(100, 23);
            this.tb_StokBarang.TabIndex = 34;
            // 
            // lb_namaBarang
            // 
            this.lb_namaBarang.AutoSize = true;
            this.lb_namaBarang.Location = new System.Drawing.Point(294, 208);
            this.lb_namaBarang.Name = "lb_namaBarang";
            this.lb_namaBarang.Size = new System.Drawing.Size(44, 15);
            this.lb_namaBarang.TabIndex = 33;
            this.lb_namaBarang.Text = "Barang";
            // 
            // cb_NamaBarang
            // 
            this.cb_NamaBarang.FormattingEnabled = true;
            this.cb_NamaBarang.Location = new System.Drawing.Point(344, 208);
            this.cb_NamaBarang.Name = "cb_NamaBarang";
            this.cb_NamaBarang.Size = new System.Drawing.Size(121, 23);
            this.cb_NamaBarang.TabIndex = 32;
            // 
            // lb_stokBarang
            // 
            this.lb_stokBarang.AutoSize = true;
            this.lb_stokBarang.Location = new System.Drawing.Point(320, 241);
            this.lb_stokBarang.Name = "lb_stokBarang";
            this.lb_stokBarang.Size = new System.Drawing.Size(30, 15);
            this.lb_stokBarang.TabIndex = 31;
            this.lb_stokBarang.Text = "Stok";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(320, 266);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(85, 23);
            this.btn_Back.TabIndex = 36;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_TambahStok
            // 
            this.btn_TambahStok.Location = new System.Drawing.Point(411, 266);
            this.btn_TambahStok.Name = "btn_TambahStok";
            this.btn_TambahStok.Size = new System.Drawing.Size(85, 23);
            this.btn_TambahStok.TabIndex = 35;
            this.btn_TambahStok.Text = "Tambah";
            this.btn_TambahStok.UseVisualStyleBackColor = true;
            this.btn_TambahStok.Click += new System.EventHandler(this.btn_TambahStok_Click);
            // 
            // f_TambahStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_TambahStok);
            this.Controls.Add(this.tb_StokBarang);
            this.Controls.Add(this.lb_namaBarang);
            this.Controls.Add(this.cb_NamaBarang);
            this.Controls.Add(this.lb_stokBarang);
            this.Name = "f_TambahStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.f_TambahStok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_StokBarang;
        private System.Windows.Forms.Label lb_namaBarang;
        private System.Windows.Forms.ComboBox cb_NamaBarang;
        private System.Windows.Forms.Label lb_stokBarang;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_TambahStok;
    }
}