using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPBO
{
    public class Barang
    {
        public string nama;
        public string jenis;
        public DateTime lastUpdate;
        public int id;
        public int harga;

        public Barang(int idBarang, string namaBarang, int hargaBarang, string jenisBarang, DateTime lastUpdateBarang)
        {
            nama = namaBarang;
            harga = hargaBarang;
            lastUpdate = lastUpdateBarang;
            id = idBarang;
            jenis = jenisBarang;
        }
    }
}
