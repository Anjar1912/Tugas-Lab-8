using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_8.ClassInduk
{
   public abstract class Pegawai
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public abstract double Gaji();
    }
}
