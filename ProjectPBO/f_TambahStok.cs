using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectPBO
{
    public partial class f_TambahStok : Form
    {
        private List<Barang> listBarang = new List<Barang>();
        public f_TambahStok()
        {
            InitializeComponent();
        }

        private void f_TambahStok_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(f_TambahBarang_Shown);
        }

        private void f_TambahBarang_Shown(object sender, EventArgs e)
        {
            readData();
            string[] nama = new string[listBarang.Count];
            for (int i = 0; i < listBarang.Count; i++)
            {
                nama.SetValue(listBarang[i].nama, i);
            }
            cb_NamaBarang.Items.AddRange(nama);
            tb_StokBarang.Enabled = false;
            this.cb_NamaBarang.SelectedValueChanged += new EventHandler(nama_Selected);
        }

        private void nama_Selected(object sender, EventArgs e)
        {
            var selected = cb_NamaBarang.SelectedIndex;
            tb_StokBarang.Enabled = true;
            btn_TambahStok.Enabled = true;
        }

        private void btn_TambahStok_Click(object sender, EventArgs e)
        {
            var selected = cb_NamaBarang.SelectedIndex;
            var id = listBarang[selected].id;
            var stok = tb_StokBarang.Text;
            addData(id, stok);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Stok stok = new f_Stok();
            stok.ShowDialog();
        }

        public void addData(int id, string stok)
        {
            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);
                conn.Open();

                // Save the barang data
                var query = "INSERT INTO `persediaan_barang` (`id_persediaan`, `id_barang`, `last_update`, `stok_tersedia`) " +
                    "VALUES (NULL, '" + id +  "', current_timestamp(), '" + stok + "')";
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

        public void readData()
        {
            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);

                // Get the data
                conn.Open();
                var query = "SELECT * FROM barang " +
                    "WHERE id_barang " +
                    "NOT IN (SELECT id_barang FROM persediaan_barang)";
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
