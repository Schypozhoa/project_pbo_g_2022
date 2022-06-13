namespace ProjectPBO
{
    partial class f_Stok
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
            this.btn_LihatStok = new System.Windows.Forms.Button();
            this.btn_TambahStok = new System.Windows.Forms.Button();
            this.btn_EditStok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LihatStok
            // 
            this.btn_LihatStok.Location = new System.Drawing.Point(328, 147);
            this.btn_LihatStok.Name = "btn_LihatStok";
            this.btn_LihatStok.Size = new System.Drawing.Size(100, 23);
            this.btn_LihatStok.TabIndex = 0;
            this.btn_LihatStok.Text = "Lihat Stok";
            this.btn_LihatStok.UseVisualStyleBackColor = true;
            // 
            // btn_TambahStok
            // 
            this.btn_TambahStok.Location = new System.Drawing.Point(328, 176);
            this.btn_TambahStok.Name = "btn_TambahStok";
            this.btn_TambahStok.Size = new System.Drawing.Size(100, 23);
            this.btn_TambahStok.TabIndex = 1;
            this.btn_TambahStok.Text = "Tambah Stok";
            this.btn_TambahStok.UseVisualStyleBackColor = true;
            // 
            // btn_EditStok
            // 
            this.btn_EditStok.Location = new System.Drawing.Point(328, 205);
            this.btn_EditStok.Name = "btn_EditStok";
            this.btn_EditStok.Size = new System.Drawing.Size(100, 23);
            this.btn_EditStok.TabIndex = 2;
            this.btn_EditStok.Text = "Edit Stok";
            this.btn_EditStok.UseVisualStyleBackColor = true;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_EditStok);
            this.Controls.Add(this.btn_TambahStok);
            this.Controls.Add(this.btn_LihatStok);
            this.Name = "Stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VESTO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LihatStok;
        private System.Windows.Forms.Button btn_TambahStok;
        private System.Windows.Forms.Button btn_EditStok;
    }
}