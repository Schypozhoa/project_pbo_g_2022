using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPBO
{
    public class Stok
    {
        public DateTime lastUpdate;
        public int id;
        public int idbarang;
        public int stok;
        public string nama;

        public Stok(int idStok, int idBarang, string namaBarang, int stokBarang, DateTime lastUpdateBarang)
        {
            id = idStok;
            idbarang = idBarang;
            nama = namaBarang;
            stok = stokBarang;
            lastUpdate = lastUpdateBarang;
        }
    }
}
