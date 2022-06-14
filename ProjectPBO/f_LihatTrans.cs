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
    public partial class f_LihatTrans : Form
    {
        private List<Transaksi> listTransaksi = new List<Transaksi>();
        public f_LihatTrans()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Transaksi trans = new f_Transaksi();
            trans.ShowDialog();
        }

        private void f_LihatTrans_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(f_LihatTrans_Shown);
        }

        private void f_LihatTrans_Shown(object sender, EventArgs e)
        {
            readData();
            DataTable data = ConvertToDatatable(listTransaksi);
            dataTrans.DataSource = data;
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

                // Get the trans data
                var query = "SELECT * FROM `transaksi` as t " +
                    "INNER JOIN detail_transaksi as dt " +
                    "ON t.id_transaksi = dt.id_transaksi " +
                    "INNER JOIN barang as b " +
                    "ON dt.id_barang = b.id_barang";
                using var cmd = new MySqlCommand(query, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listTransaksi.Add(new Transaksi(rdr.GetInt32(0), rdr.GetString(9), rdr.GetInt32(10), rdr.GetInt32(7), rdr.GetInt32(2), rdr.GetDateTime(1), rdr.GetString(3)));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static DataTable ConvertToDatatable(List<Transaksi> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nama Barang");
            dt.Columns.Add("Harga Barang");
            dt.Columns.Add("Jumlah");
            dt.Columns.Add("Keterangan");
            dt.Columns.Add("Waktu Transaksi");
            foreach (var trans in list)
            {
                var row = dt.NewRow();

                row["ID"] = trans.idTrans.ToString();
                row["Nama Barang"] = trans.namaBarang;
                row["Harga Barang"] = trans.hargaBarang.ToString();
                row["Jumlah"] = trans.jumlah.ToString();
                row["Keterangan"] = trans.keterangan;
                row["Waktu Transaksi"] = trans.waktuTrans.ToString();

                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
