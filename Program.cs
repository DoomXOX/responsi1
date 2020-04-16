using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2914
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(184422, "Dimas", 400000);
            Karyawan karyawan2 = new Karyawan(184343, "Indah", -100);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Asiqqq naik gaji nih");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();


        }
    }
}
