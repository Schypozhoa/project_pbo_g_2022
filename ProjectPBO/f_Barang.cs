using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPBO
{
    public partial class f_Barang : Form
    {
        public f_Barang()
        {
            InitializeComponent();
        }

        private void btn_LihatBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_LihatBarang lihatBarang = new f_LihatBarang();
            lihatBarang.ShowDialog();
        }

        private void btn_TambahBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_TambahBarang tambahBarang = new f_TambahBarang();
            tambahBarang.ShowDialog();
        }

        private void btn_EditBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_EditBarang editBarang = new f_EditBarang();
            editBarang.ShowDialog();
        }

        private void btn_HapusBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_HapusBarang hapusBarang = new f_HapusBarang();
            hapusBarang.ShowDialog();
        }
    }
}
