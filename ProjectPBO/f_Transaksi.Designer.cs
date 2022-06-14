namespace ProjectPBO
{
    partial class f_Transaksi
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
            this.btn_LihatTrans = new System.Windows.Forms.Button();
            this.btn_TambahTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LihatTrans
            // 
            this.btn_LihatTrans.Location = new System.Drawing.Point(334, 147);
            this.btn_LihatTrans.Name = "btn_LihatTrans";
            this.btn_LihatTrans.Size = new System.Drawing.Size(115, 23);
            this.btn_LihatTrans.TabIndex = 4;
            this.btn_LihatTrans.Text = "Lihat Transaksi";
            this.btn_LihatTrans.UseVisualStyleBackColor = true;
            this.btn_LihatTrans.Click += new System.EventHandler(this.btn_LihatTrans_Click);
            // 
            // btn_TambahTrans
            // 
            this.btn_TambahTrans.Location = new System.Drawing.Point(334, 176);
            this.btn_TambahTrans.Name = "btn_TambahTrans";
            this.btn_TambahTrans.Size = new System.Drawing.Size(115, 23);
            this.btn_TambahTrans.TabIndex = 3;
            this.btn_TambahTrans.Text = "Tambah Transaksi";
            this.btn_TambahTrans.UseVisualStyleBackColor = true;
            this.btn_TambahTrans.Click += new System.EventHandler(this.btn_TambahTrans_Click);
            // 
            // f_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_LihatTrans);
            this.Controls.Add(this.btn_TambahTrans);
            this.Name = "f_Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LihatTrans;
        private System.Windows.Forms.Button btn_TambahTrans;
    }
}