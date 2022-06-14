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
    public partial class f_TambahTrans : Form
    {
        private List<Barang> listBarang = new List<Barang>();
        private List<Barang> listPembelian = new List<Barang>();
        private List<Stok> listStok = new List<Stok>();
        private List<int> listJumlah = new List<int>();
        private int total = 0;
        public f_TambahTrans()
        {
            InitializeComponent();
        }

        private void f_TambahTrans_Load(object sender, EventArgs e)
        {
            lb_HargaHolder.Text = "Rp.-";
            this.Shown += new EventHandler(f_TambahTrans_Shown);
        }

        private void f_TambahTrans_Shown(object sender, EventArgs e)
        {
            readData();
            string[] nama = new string[listBarang.Count];
            for (int i = 0; i < listBarang.Count; i++)
            {
                nama.SetValue(listBarang[i].nama, i);
            }
            cb_NamaBarang.Items.AddRange(nama);
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

            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);
                conn.Open();

                // Get the stok data
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

        private void btn_TambahBarang_Click(object sender, EventArgs e)
        {
            var selected = cb_NamaBarang.SelectedIndex;
            var jumlah = Convert.ToInt32(tb_Jumlah.Text);

            int idx = listStok.FindIndex(x => x.idbarang == listBarang[selected].id);
            if (listStok[idx].stok >= jumlah)
            {
                listPembelian.Add(listBarang[selected]);
                listJumlah.Add(jumlah);
                total += listBarang[selected].harga * jumlah;
                lb_HargaHolder.Text = "Rp." + total;
                dataPembelian.DataSource = ConvertToDatatable(listPembelian, listJumlah);
                tb_Jumlah.Text = "";
                cb_NamaBarang.ResetText();
                cb_NamaBarang.SelectedIndex = -1;
            } 
            else
            {
                MessageBox.Show("Stok tidak mencukupi, sisa stok saat ini adalah " + listStok[idx].stok);
                tb_Jumlah.Text = "";
                cb_NamaBarang.ResetText();
                cb_NamaBarang.SelectedIndex = -1;
            }

        }

        static DataTable ConvertToDatatable(List<Barang> list, List<int> list2)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nama");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Jumlah");
            var idx = 0;
            foreach (var barang in list)
            {
                var row = dt.NewRow();

                row["Nama"] = barang.nama;
                row["Harga"] = Convert.ToString(barang.harga);
                row["Jumlah"] = list2[idx];

                dt.Rows.Add(row);
                idx++;
            }

            return dt;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Transaksi trans = new f_Transaksi();
            trans.ShowDialog();
        }

        private void btn_TambahTransaksi_Click(object sender, EventArgs e)
        {
            string keterangan;
            if (tb_Keterangan.Text == "" || tb_Keterangan.Text == null)
            {
                keterangan = "Tidak ada";
            }
            else 
            {
                keterangan = tb_Keterangan.Text;
            }
            var transID = addData(total, keterangan);
            addDataDetail(transID, listPembelian, listJumlah);
            listPembelian.Clear();
            listJumlah.Clear();
            dataPembelian.DataSource = ConvertToDatatable(listPembelian, listJumlah);
        }

        public int addData(int total, string keterangan)
        {
            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);
                conn.Open();

                // Save the trans data
                var query = "INSERT INTO `transaksi` (`id_transaksi`, `tanggal`, `total_harga`, `keterangan`) VALUES (NULL, current_timestamp(), '" + total + "', '" + keterangan + "')";
                using var cmd = new MySqlCommand(query, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                int lastID = Convert.ToInt32(cmd.LastInsertedId);
                conn.Close();
                MessageBox.Show("Data Tersimpan");
                return lastID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public void addDataDetail(int transID, List<Barang> l_barang, List<int> l_jumlah)
        {
            try
            {
                if (transID == -1)
                {
                    throw new InvalidOperationException("id_transaksi invalid, got "+transID);
                }
                else
                {
                    // Initialize db connection
                    var db = new MySQLDB();
                    var arg = db.getArg();
                    var conn = new MySqlConnection(arg);

                    // Save the detail data
                    var idx = 0;
                    foreach (var barang in l_barang)
                    {
                        conn.Open();
                        var query = "INSERT INTO `detail_transaksi` (`id_detail`, `id_transaksi`, `id_barang`, `jumlah`) VALUES (NULL, '" + transID + "', '" + barang.id + "', '" + l_jumlah[idx] + "')";
                        using var cmd = new MySqlCommand(query, conn);
                        using MySqlDataReader rdr = cmd.ExecuteReader();
                        conn.Close();
                        idx++;
                    }


                    MessageBox.Show("Data Tersimpan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
