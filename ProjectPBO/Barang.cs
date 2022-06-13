using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPBO
{
    internal class Barang
    {
        public string nama;
        public int harga;
        public int stok;
        public Barang(string namaBarang, int hargaBarang, int stokBarang)
        {
            nama = namaBarang;
            harga = hargaBarang;
            stok = stokBarang;
        }
    }
}
