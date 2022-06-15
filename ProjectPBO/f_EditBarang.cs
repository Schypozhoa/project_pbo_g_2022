using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPBO
{
    public partial class f_EditBarang : Form
    {
        private List<Barang> listBarang = new List<Barang>();

        public f_EditBarang()
        {
            InitializeComponent();
        }

        private void f_EditBarang_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(f_LihatBarang_Shown);
        }

        private void f_LihatBarang_Shown(object sender, EventArgs e)
        {
            readData();
            string[] nama = new string[listBarang.Count];
            for (int i = 0; i < listBarang.Count; i++)
            {
                nama.SetValue(listBarang[i].nama, i);
            }
            cb_NamaBarang.Items.AddRange(nama);
            tb_NamaBarang.Enabled = false;
            tb_HargaBarang.Enabled = false;
            cb_JenisBarang.Enabled = false;
            btn_UbahBarang.Text = "Pilih Barang Terlebih Dahulu";
            btn_UbahBarang.Enabled = false;
            this.cb_NamaBarang.SelectedValueChanged += new EventHandler(nama_Selected);
        }

        private void nama_Selected(object sender, EventArgs e)
        {
            var selected = cb_NamaBarang.SelectedIndex;
            if (selected != -1)
            {
                btn_UbahBarang.Text = "Simpan";
                tb_NamaBarang.Text = listBarang[selected].nama;
                tb_NamaBarang.Enabled = true;
                tb_HargaBarang.Text = listBarang[selected].harga.ToString();
                tb_HargaBarang.Enabled = true;
                cb_JenisBarang.SelectedIndex = cb_JenisBarang.FindStringExact(listBarang[selected].jenis);
                cb_JenisBarang.Enabled = true;
                btn_UbahBarang.Enabled = true;
            }
        }

        private void btn_UbahBarang_Click(object sender, EventArgs e)
        {
            btn_UbahBarang.Text = "Menyimpan...";
            btn_UbahBarang.Enabled = false;
            var selected = cb_NamaBarang.SelectedIndex;
            var id = listBarang[selected].id;
            var nama = tb_NamaBarang.Text;
            var harga = tb_HargaBarang.Text;
            var jenis = cb_JenisBarang.Text;
            editData(id, nama, harga, jenis);
            cb_NamaBarang.ResetText();
            cb_NamaBarang.SelectedIndex = -1;
            tb_NamaBarang.Text = "";
            tb_HargaBarang.Text = "";
            cb_JenisBarang.ResetText();
            cb_JenisBarang.SelectedIndex = -1;
            btn_UbahBarang.Text = "Simpan";
            btn_UbahBarang.Enabled = true;
        }

        public void editData(int id, string nama, string harga, string jenis)
        {
            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);
                conn.Open();

                // Save the barang data
                var query = "UPDATE `barang` SET `nama_barang` = '" + nama + "', `harga_barang` = '" + harga + "', " +
                    "`jenis` = '" + jenis + "', `last_updated` = current_timestamp() " +
                    "WHERE `barang`.`id_barang` = " + id;
                using var cmd = new MySqlCommand(query, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Data Tersimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Barang barang = new f_Barang();
            barang.ShowDialog();
        }

        public void readData()
        {
            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);
                conn.Open();

                // Get the barang data
                var query = "SELECT * from barang";
                using var cmd = new MySqlCommand(query, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listBarang.Add(new Barang(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetString(3), rdr.GetDateTime(4)));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            this.Hide();
            f_Barang barang = new f_Barang();
            barang.ShowDialog();
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
