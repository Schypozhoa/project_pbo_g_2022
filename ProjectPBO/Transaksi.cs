using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPBO
{
    public class Transaksi
    {
        public int idTrans;
        public string namaBarang;
        public int hargaBarang;
        public int jumlah;
        public int totalHarga;
        public DateTime waktuTrans;
        public string keterangan;

        public Transaksi(int idTransaksi, string namaBarang, int hargaBarang, int jumlah, int totalHarga, DateTime tanggal, string keterangan)
        {
            idTrans = idTransaksi;
            this.namaBarang = namaBarang;
            this.hargaBarang = hargaBarang;
            this.jumlah = jumlah;
            this.totalHarga = totalHarga;
            waktuTrans = tanggal;
            this.keterangan = keterangan;
        }
    }
}
