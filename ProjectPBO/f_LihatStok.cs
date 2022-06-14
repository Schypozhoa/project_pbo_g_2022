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
    public partial class f_LihatStok : Form
    {
        private List<Stok> listStok = new List<Stok>();
        public f_LihatStok()
        {
            InitializeComponent();
        }

        private void f_LihatStok_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(f_LihatStok_Shown);
        }

        private void f_LihatStok_Shown(object sender, EventArgs e)
        {
            readData();
            DataTable data = ConvertToDatatable(listStok);
            dataStok.DataSource = data;
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

        static DataTable ConvertToDatatable(List<Stok> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nama");
            dt.Columns.Add("Stok");
            dt.Columns.Add("Last Update");
            foreach (var barang in list)
            {
                var row = dt.NewRow();

                row["ID"] = Convert.ToString(barang.id);
                row["Nama"] = barang.nama;
                row["Stok"] = Convert.ToString(barang.stok);
                row["Last Update"] = Convert.ToString(barang.lastUpdate);

                dt.Rows.Add(row);
            }

            return dt;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_Stok stok = new f_Stok();
            stok.ShowDialog();
        }
    }
}
