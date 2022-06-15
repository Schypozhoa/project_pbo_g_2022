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

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Home home = new f_Home();
            home.ShowDialog();
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Stok stok = new f_Stok();
            stok.ShowDialog();
        }

        private void btn_Barang_Click(object sender, EventArgs e)
        {

        }

        private void btn_Transaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Transaksi transaksi = new f_Transaksi();
            transaksi.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
