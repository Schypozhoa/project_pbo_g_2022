using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPBO
{
    public partial class f_Transaksi : Form
    {
        public f_Transaksi()
        {
            InitializeComponent();
        }

        private void btn_LihatTrans_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_LihatTrans lihatTrans = new f_LihatTrans();
            lihatTrans.ShowDialog();
        }

        private void btn_TambahTrans_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_TambahTrans tambahTrans = new f_TambahTrans();
            tambahTrans.ShowDialog();
        }

        private void btn_Stok_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Stok stok = new f_Stok();
            stok.ShowDialog();
        }

        private void btn_Barang_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Barang barang = new f_Barang();
            barang.ShowDialog();
        }

        private void btn_Transaksi_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Home home = new f_Home();
            home.ShowDialog();
        }
    }
}
