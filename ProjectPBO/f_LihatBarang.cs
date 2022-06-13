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
            
            dbConnection();
            DataTable data = ConvertToDatatable(listBarang);
            dataBarang.DataSource = data;
        }

        public void dbConnection()
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
                listBarang.Add(new Barang(rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3)));
            }
            conn.Close();
        }

        static DataTable ConvertToDatatable(List<Barang> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nama");
            dt.Columns.Add("Harga");
            foreach (var barang in list)
            {
                var row = dt.NewRow();

                row["Nama"] = barang.nama;
                row["Harga"] = Convert.ToString(barang.harga);

                dt.Rows.Add(row);
            }

            return dt;
        }

        private void btn_backLihatBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Barang barang = new f_Barang();
            barang.ShowDialog();
        }
    }
}
