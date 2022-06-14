namespace ProjectPBO
{
    partial class f_Barang
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
            this.btn_EditBarang = new System.Windows.Forms.Button();
            this.btn_TambahBarang = new System.Windows.Forms.Button();
            this.btn_LihatBarang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_EditBarang
            // 
            this.btn_EditBarang.Location = new System.Drawing.Point(327, 224);
            this.btn_EditBarang.Name = "btn_EditBarang";
            this.btn_EditBarang.Size = new System.Drawing.Size(100, 23);
            this.btn_EditBarang.TabIndex = 5;
            this.btn_EditBarang.Text = "Edit Barang";
            this.btn_EditBarang.UseVisualStyleBackColor = true;
            this.btn_EditBarang.Click += new System.EventHandler(this.btn_EditBarang_Click);
            // 
            // btn_TambahBarang
            // 
            this.btn_TambahBarang.Location = new System.Drawing.Point(327, 195);
            this.btn_TambahBarang.Name = "btn_TambahBarang";
            this.btn_TambahBarang.Size = new System.Drawing.Size(100, 23);
            this.btn_TambahBarang.TabIndex = 4;
            this.btn_TambahBarang.Text = "Tambah Barang";
            this.btn_TambahBarang.UseVisualStyleBackColor = true;
            this.btn_TambahBarang.Click += new System.EventHandler(this.btn_TambahBarang_Click);
            // 
            // btn_LihatBarang
            // 
            this.btn_LihatBarang.Location = new System.Drawing.Point(327, 166);
            this.btn_LihatBarang.Name = "btn_LihatBarang";
            this.btn_LihatBarang.Size = new System.Drawing.Size(100, 23);
            this.btn_LihatBarang.TabIndex = 3;
            this.btn_LihatBarang.Text = "Lihat Barang";
            this.btn_LihatBarang.UseVisualStyleBackColor = true;
            this.btn_LihatBarang.Click += new System.EventHandler(this.btn_LihatBarang_Click);
            // 
            // f_Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EditBarang);
            this.Controls.Add(this.btn_TambahBarang);
            this.Controls.Add(this.btn_LihatBarang);
            this.Name = "f_Barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_EditBarang;
        private System.Windows.Forms.Button btn_TambahBarang;
        private System.Windows.Forms.Button btn_LihatBarang;
    }
}