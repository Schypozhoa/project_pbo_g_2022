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
    public partial class f_LihatBarang : Form
    {
        private List<Barang> listBarang = new List<Barang>();

        public f_LihatBarang()
        {
            InitializeComponent();
        }

        private void f_LihatBarang_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(f_LihatBarang_Shown);
        }

        private void f_LihatBarang_Shown(object sender, EventArgs e)
        {
            readData();
            DataTable data = ConvertToDatatable(listBarang);
            dataBarang.DataSource = data;
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

        static DataTable ConvertToDatatable(List<Barang> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Harga");
            dt.Columns.Add("Jenis");
            dt.Columns.Add("Last Update");
            foreach (var barang in list)
            {
                var row = dt.NewRow();

                row["ID"] = Convert.ToString(barang.id);
                row["Nama"] = barang.nama;
                row["Harga"] = Convert.ToString(barang.harga);
                row["Jenis"] = barang.jenis;
                row["Last Update"] = Convert.ToString(barang.lastUpdate);

                dt.Rows.Add(row);
            }

            return dt;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Barang barang = new f_Barang();
            barang.ShowDialog();
        }
    }
}
