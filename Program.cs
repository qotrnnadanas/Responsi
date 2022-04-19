using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan1 = new Karyawan();

            karyawan1.NIK = "21114354";
            karyawan1.NAMA = "Qotrun";
            karyawan1.GajiBulanan = 3000000;

            Karyawan karyawan2 = new Karyawan();

            karyawan2.NIK = "12332112";
            karyawan2.NAMA = "Nasrulloh";
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine("No  Nik\t\tNama\tGaji Bulanan");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1. {0} {1}\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("asyiiiikkkkk kenaikan gaji 10%");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1. {0} {1}\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.1));
            Console.WriteLine("2. {0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.1));
            Console.ReadKey();
        }
    }
}