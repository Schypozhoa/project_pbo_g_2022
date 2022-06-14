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
            this.tb_StokBarang = new System.Windows.Forms.TextBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.cb_NamaBarang = new System.Windows.Forms.ComboBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_UbahStok = new System.Windows.Forms.Button();
            this.lb_stokBarang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_StokBarang
            // 
            this.tb_StokBarang.Location = new System.Drawing.Point(359, 126);
            this.tb_StokBarang.Name = "tb_StokBarang";
            this.tb_StokBarang.Size = new System.Drawing.Size(100, 23);
            this.tb_StokBarang.TabIndex = 30;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(331, 79);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(143, 15);
            this.lb_Title.TabIndex = 29;
            this.lb_Title.Text = "Barang yang ingin diubah";
            // 
            // cb_NamaBarang
            // 
            this.cb_NamaBarang.FormattingEnabled = true;
            this.cb_NamaBarang.Location = new System.Drawing.Point(338, 97);
            this.cb_NamaBarang.Name = "cb_NamaBarang";
            this.cb_NamaBarang.Size = new System.Drawing.Size(121, 23);
            this.cb_NamaBarang.TabIndex = 28;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(331, 348);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(85, 23);
            this.btn_Back.TabIndex = 27;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_UbahStok
            // 
            this.btn_UbahStok.Location = new System.Drawing.Point(422, 348);
            this.btn_UbahStok.Name = "btn_UbahStok";
            this.btn_UbahStok.Size = new System.Drawing.Size(85, 23);
            this.btn_UbahStok.TabIndex = 26;
            this.btn_UbahStok.Text = "Simpan";
            this.btn_UbahStok.UseVisualStyleBackColor = true;
            this.btn_UbahStok.Click += new System.EventHandler(this.btn_UbahStok_Click);
            // 
            // lb_stokBarang
            // 
            this.lb_stokBarang.AutoSize = true;
            this.lb_stokBarang.Location = new System.Drawing.Point(314, 130);
            this.lb_stokBarang.Name = "lb_stokBarang";
            this.lb_stokBarang.Size = new System.Drawing.Size(30, 15);
            this.lb_stokBarang.TabIndex = 21;
            this.lb_stokBarang.Text = "Stok";
            // 
            // f_EditStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_StokBarang);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.cb_NamaBarang);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_UbahStok);
            this.Controls.Add(this.lb_stokBarang);
            this.Name = "f_EditStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.f_EditStok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_StokBarang;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.ComboBox cb_NamaBarang;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_UbahStok;
        private System.Windows.Forms.Label lb_stokBarang;
    }
}