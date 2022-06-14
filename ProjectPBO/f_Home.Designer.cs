namespace ProjectPBO
{
    partial class f_Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Stok = new System.Windows.Forms.Button();
            this.btn_Barang = new System.Windows.Forms.Button();
            this.btn_Transaksi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOME";
            // 
            // btn_Stok
            // 
            this.btn_Stok.Location = new System.Drawing.Point(325, 102);
            this.btn_Stok.Name = "btn_Stok";
            this.btn_Stok.Size = new System.Drawing.Size(75, 23);
            this.btn_Stok.TabIndex = 1;
            this.btn_Stok.Text = "Stok";
            this.btn_Stok.UseVisualStyleBackColor = true;
            this.btn_Stok.Click += new System.EventHandler(this.btn_stok_Click);
            // 
            // btn_Barang
            // 
            this.btn_Barang.Location = new System.Drawing.Point(325, 73);
            this.btn_Barang.Name = "btn_Barang";
            this.btn_Barang.Size = new System.Drawing.Size(75, 23);
            this.btn_Barang.TabIndex = 2;
            this.btn_Barang.Text = "Barang";
            this.btn_Barang.UseVisualStyleBackColor = true;
            this.btn_Barang.Click += new System.EventHandler(this.btn_Barang_Click);
            // 
            // btn_Transaksi
            // 
            this.btn_Transaksi.Location = new System.Drawing.Point(325, 131);
            this.btn_Transaksi.Name = "btn_Transaksi";
            this.btn_Transaksi.Size = new System.Drawing.Size(75, 23);
            this.btn_Transaksi.TabIndex = 3;
            this.btn_Transaksi.Text = "Transaksi";
            this.btn_Transaksi.UseVisualStyleBackColor = true;
            this.btn_Transaksi.Click += new System.EventHandler(this.btn_Transaksi_Click);
            // 
            // f_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Transaksi);
            this.Controls.Add(this.btn_Barang);
            this.Controls.Add(this.btn_Stok);
            this.Controls.Add(this.label1);
            this.Name = "f_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Stok;
        private System.Windows.Forms.Button btn_Barang;
        private System.Windows.Forms.Button btn_Transaksi;
    }
}
