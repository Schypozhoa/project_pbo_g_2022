namespace ProjectPBO
{
    partial class f_LihatTrans
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
            this.dataTrans = new System.Windows.Forms.DataGridView();
            this.lb_LihatTrans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(361, 412);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataTrans
            // 
            this.dataTrans.AllowUserToAddRows = false;
            this.dataTrans.AllowUserToDeleteRows = false;
            this.dataTrans.AllowUserToResizeColumns = false;
            this.dataTrans.AllowUserToResizeRows = false;
            this.dataTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrans.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataTrans.Location = new System.Drawing.Point(12, 50);
            this.dataTrans.MultiSelect = false;
            this.dataTrans.Name = "dataTrans";
            this.dataTrans.ReadOnly = true;
            this.dataTrans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTrans.RowTemplate.Height = 25;
            this.dataTrans.Size = new System.Drawing.Size(776, 312);
            this.dataTrans.TabIndex = 7;
            // 
            // lb_LihatTrans
            // 
            this.lb_LihatTrans.AutoSize = true;
            this.lb_LihatTrans.Location = new System.Drawing.Point(353, 16);
            this.lb_LihatTrans.Name = "lb_LihatTrans";
            this.lb_LihatTrans.Size = new System.Drawing.Size(54, 15);
            this.lb_LihatTrans.TabIndex = 6;
            this.lb_LihatTrans.Text = "Transaksi";
            // 
            // f_LihatTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dataTrans);
            this.Controls.Add(this.lb_LihatTrans);
            this.Name = "f_LihatTrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.f_LihatTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dataTrans;
        private System.Windows.Forms.Label lb_LihatTrans;
    }
}