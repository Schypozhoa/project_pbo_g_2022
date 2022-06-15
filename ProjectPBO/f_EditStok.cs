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
    public partial class f_EditStok : Form
    {
        private List<Stok> listStok = new List<Stok> ();
        public f_EditStok()
        {
            InitializeComponent();
        }

        private void f_EditStok_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(f_UbahStok_Shown);
        }

        private void f_UbahStok_Shown(object sender, EventArgs e)
        {
            readData();
            string[] nama = new string[listStok.Count];
            for (int i = 0; i < listStok.Count; i++)
            {
                nama.SetValue(listStok[i].nama, i);
            }
            cb_NamaBarang.Items.AddRange(nama);
            tb_StokBarang.Enabled = false;
            this.cb_NamaBarang.SelectedValueChanged += new EventHandler(nama_Selected);
        }

        private void nama_Selected(object sender, EventArgs e)
        {
            var selected = cb_NamaBarang.SelectedIndex;
            tb_StokBarang.Text = listStok[selected].stok.ToString();
            tb_StokBarang.Enabled = true;
            btn_UbahStok.Enabled = true;
        }

        private void btn_UbahStok_Click(object sender, EventArgs e)
        {
            var selected = cb_NamaBarang.SelectedIndex;
            var idStok = listStok[selected].id;
            var stok = tb_StokBarang.Text;
            editData(idStok, stok);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Stok stok = new f_Stok();
            stok.ShowDialog();
        }

        public void editData(int idStok, string stok)
        {
            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);
                conn.Open();

                // Save the barang data
                var query = "UPDATE `persediaan_barang` SET `stok_tersedia` = '" + stok + "'" +
                    "WHERE `persediaan_barang`.`id_persediaan` = " + idStok;
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
                var query = "SELECT * from persediaan_barang as pb " +
                    "INNER JOIN barang as b " +
                    "ON pb.id_barang = b.id_barang";
                using var cmd = new MySqlCommand(query, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listStok.Add(new Stok(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetString(5), rdr.GetInt32(3), rdr.GetDateTime(2)));
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
