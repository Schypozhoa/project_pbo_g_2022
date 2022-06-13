namespace ProjectPBO
{
    partial class f_LihatBarang
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
            this.lb_LihatBarang = new System.Windows.Forms.Label();
            this.dataBarang = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LihatBarang
            // 
            this.lb_LihatBarang.AutoSize = true;
            this.lb_LihatBarang.Location = new System.Drawing.Point(353, 9);
            this.lb_LihatBarang.Name = "lb_LihatBarang";
            this.lb_LihatBarang.Size = new System.Drawing.Size(44, 15);
            this.lb_LihatBarang.TabIndex = 0;
            this.lb_LihatBarang.Text = "Barang";
            // 
            // dataBarang
            // 
            this.dataBarang.AllowUserToAddRows = false;
            this.dataBarang.AllowUserToDeleteRows = false;
            this.dataBarang.AllowUserToResizeColumns = false;
            this.dataBarang.AllowUserToResizeRows = false;
            this.dataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBarang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataBarang.Location = new System.Drawing.Point(12, 43);
            this.dataBarang.MultiSelect = false;
            this.dataBarang.Name = "dataBarang";
            this.dataBarang.ReadOnly = true;
            this.dataBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataBarang.RowTemplate.Height = 25;
            this.dataBarang.Size = new System.Drawing.Size(776, 312);
            this.dataBarang.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(361, 405);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // f_LihatBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dataBarang);
            this.Controls.Add(this.lb_LihatBarang);
            this.Name = "f_LihatBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VESTO";
            this.Load += new System.EventHandler(this.f_LihatBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_LihatBarang;
        private System.Windows.Forms.DataGridView dataBarang;
        private System.Windows.Forms.Button btn_Back;
    }
}