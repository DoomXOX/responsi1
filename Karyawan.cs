﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2914
{
    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if(gaji < 0)
            {
                this.gajiBulanan = 0;
            } else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            double temp = 0;
            temp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", nik, nama, gajiBulanan);
        }


    }
}
