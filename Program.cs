using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Lab_8.ClassAnak;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inhertance, Polimorphism, Abstraction & Collection";
            //membuat objek untuk semua karyawan

            PegawaiTetap pegawaiTetap = new PegawaiTetap();
            pegawaiTetap.Nik = "123-456-789";
            pegawaiTetap.Nama = "Anjar Tri Sasongko";
            pegawaiTetap.GajiBulanan = 9000000;

            PegawaiHarian pegawaiHarian = new PegawaiHarian();
            pegawaiHarian.Nik = "123-789-456";
            pegawaiHarian.Nama = "Amin Syaisar Toumahu";
            pegawaiHarian.JumlahJamKeja = 7;
            pegawaiHarian.UpahPerJam = 200000;

            Leader leader = new Leader();
            leader.Nik = "123-567-981";
            leader.Nama = "Akbar Nurrizky";
            leader.JumlahPenjualan = 50;
            leader.Komisi = 50000;

            //objek class collection
            List<Pegawai> listPegawai = new List<Pegawai>();

            listPegawai.Add(pegawaiTetap);
            listPegawai.Add(pegawaiHarian);
            listPegawai.Add(leader);

            int noUrut = 1;

            foreach (Pegawai pegawai in listPegawai)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji {3}",
                    noUrut, pegawai.Nik, pegawai.Nama, pegawai.Gaji());

                noUrut++;
            }

        }
    }
}
