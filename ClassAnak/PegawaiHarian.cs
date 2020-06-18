using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Lab_8.ClassInduk;

namespace Tugas_Lab_8.ClassAnak
{
    public class PegawaiHarian : Pegawai
    {
        public int JumlahJamKeja { get; set; }
        public int UpahPerJam { get; set; }
        public override double Gaji()
        {
            return JumlahJamKeja * UpahPerJam;
        }

    }
}
