using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPBO
{
    public partial class f_Stok : Form
    {
        public f_Stok()
        {
            InitializeComponent();
        }

        private void btn_LihatStok_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_LihatStok lihatStok = new f_LihatStok();
            lihatStok.ShowDialog();
        }

        private void btn_TambahStok_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_TambahStok tambahStok = new f_TambahStok();
            tambahStok.ShowDialog();
        }

        private void btn_EditStok_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_EditStok editStok = new f_EditStok();
            editStok.ShowDialog();
        }
    }
}
