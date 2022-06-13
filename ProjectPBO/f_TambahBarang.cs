using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectPBO
{
    public partial class f_TambahBarang : Form
    {
        public f_TambahBarang()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Barang barang = new f_Barang();
            barang.ShowDialog();
        }

        private void btn_TambahBarang_Click(object sender, EventArgs e)
        {
            var nama = tb_NamaBarang.Text;
            var harga = tb_HargaBarang.Text;
            var jenis = cb_JenisBarang.Text;
            addData(nama, harga, jenis);
        }

        public void addData(string nama, string harga, string jenis)
        {
            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);
                conn.Open();

                // Save the barang data
                var query = "INSERT INTO `barang` (`id_barang`, `nama_barang`, `harga_barang`, `jenis`, `last_updated`) " +
                    "VALUES (NULL, '" + nama +"', '" + harga + "', '" + jenis +"', current_timestamp())";
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
    }
}
