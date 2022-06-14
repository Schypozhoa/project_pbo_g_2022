namespace ProjectPBO
{
    partial class f_LihatStok
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
            this.dataStok = new System.Windows.Forms.DataGridView();
            this.lb_LihatStok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataStok)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(361, 412);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataStok
            // 
            this.dataStok.AllowUserToAddRows = false;
            this.dataStok.AllowUserToDeleteRows = false;
            this.dataStok.AllowUserToResizeColumns = false;
            this.dataStok.AllowUserToResizeRows = false;
            this.dataStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataStok.Location = new System.Drawing.Point(12, 50);
            this.dataStok.MultiSelect = false;
            this.dataStok.Name = "dataStok";
            this.dataStok.ReadOnly = true;
            this.dataStok.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataStok.RowTemplate.Height = 25;
            this.dataStok.Size = new System.Drawing.Size(776, 312);
            this.dataStok.TabIndex = 4;
            // 
            // lb_LihatStok
            // 
            this.lb_LihatStok.AutoSize = true;
            this.lb_LihatStok.Location = new System.Drawing.Point(353, 16);
            this.lb_LihatStok.Name = "lb_LihatStok";
            this.lb_LihatStok.Size = new System.Drawing.Size(30, 15);
            this.lb_LihatStok.TabIndex = 3;
            this.lb_LihatStok.Text = "Stok";
            // 
            // f_LihatStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dataStok);
            this.Controls.Add(this.lb_LihatStok);
            this.Name = "f_LihatStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.f_LihatStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DataGridView dataStok;
        private System.Windows.Forms.Label lb_LihatStok;
    }
}