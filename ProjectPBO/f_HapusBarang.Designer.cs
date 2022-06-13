namespace ProjectPBO
{
    partial class f_HapusBarang
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.cb_NamaBarang = new System.Windows.Forms.ComboBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_HapusBarang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(296, 165);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(148, 15);
            this.lb_Title.TabIndex = 21;
            this.lb_Title.Text = "Barang yang ingin dihapus";
            // 
            // cb_NamaBarang
            // 
            this.cb_NamaBarang.FormattingEnabled = true;
            this.cb_NamaBarang.Location = new System.Drawing.Point(303, 183);
            this.cb_NamaBarang.Name = "cb_NamaBarang";
            this.cb_NamaBarang.Size = new System.Drawing.Size(121, 23);
            this.cb_NamaBarang.TabIndex = 20;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(277, 222);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(85, 23);
            this.btn_Back.TabIndex = 23;
            this.btn_Back.Text = "Kembali";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_HapusBarang
            // 
            this.btn_HapusBarang.Location = new System.Drawing.Point(368, 222);
            this.btn_HapusBarang.Name = "btn_HapusBarang";
            this.btn_HapusBarang.Size = new System.Drawing.Size(85, 23);
            this.btn_HapusBarang.TabIndex = 22;
            this.btn_HapusBarang.Text = "Hapus";
            this.btn_HapusBarang.UseVisualStyleBackColor = true;
            this.btn_HapusBarang.Click += new System.EventHandler(this.btn_HapusBarang_Click);
            // 
            // f_HapusBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_HapusBarang);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.cb_NamaBarang);
            this.Name = "f_HapusBarang";
            this.Text = "f_HapusBarang";
            this.Load += new System.EventHandler(this.f_HapusBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.ComboBox cb_NamaBarang;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_HapusBarang;
    }
}