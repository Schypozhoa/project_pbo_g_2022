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
    public partial class f_HapusBarang : Form
    {
        private List<Barang> listBarang = new List<Barang>();

        public f_HapusBarang()
        {
            InitializeComponent();
        }

        private void f_HapusBarang_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(f_HapusBarang_Shown);
        }

        private void f_HapusBarang_Shown(object sender, EventArgs e)
        {
            readData();
            string[] nama = new string[listBarang.Count];
            for (int i = 0; i < listBarang.Count; i++)
            {
                nama.SetValue(listBarang[i].nama, i);
            }
            cb_NamaBarang.Items.AddRange(nama);
            btn_HapusBarang.Enabled = false;
            this.cb_NamaBarang.SelectedValueChanged += new EventHandler(nama_Selected);
        }

        private void nama_Selected(object sender, EventArgs e)
        {
            btn_HapusBarang.Enabled = true;
        }

        private void btn_HapusBarang_Click(object sender, EventArgs e)
        {
            var selected = cb_NamaBarang.SelectedIndex;
            var id = listBarang[selected].id;
            deleteData(id);
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

        public void deleteData(int id)
        {
            try
            {
                // Initialize db connection
                var db = new MySQLDB();
                var arg = db.getArg();
                var conn = new MySqlConnection(arg);
                conn.Open();

                // Get the barang data
                var query = "DELETE from barang " +
                    "WHERE `barang`.`id_barang` = " + id; ;
                using var cmd = new MySqlCommand(query, conn);
                using MySqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Data Terhapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
