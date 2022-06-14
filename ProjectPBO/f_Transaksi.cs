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
    }
}
