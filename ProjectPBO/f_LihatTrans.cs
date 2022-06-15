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
            styleDataGrid();
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

        private void styleDataGrid()
        {
            dataTrans.BorderStyle = BorderStyle.None;
            dataTrans.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataTrans.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataTrans.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataTrans.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataTrans.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataTrans.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            dataTrans.EnableHeadersVisualStyles = false;
            dataTrans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataTrans.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 10);
            dataTrans.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dataTrans.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataTrans.AutoResizeColumns();
            dataTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataTrans.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
