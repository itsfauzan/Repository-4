using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classobj
{
    public class Program
    {
        public static void Main()
        {
            Class mobil1 = new Class();

            mobil1.Warna = "Hitam";
            mobil1.JumlahPintu = 2;
            mobil1.Merk = "BMW";
            mobil1.Model = "E30 Coupe";
            mobil1.TahunKeluar = 1982;

            mobil1.Gas(100);
            mobil1.Klakson("teeeeet");
            mobil1.Tampilkaninfo();



            Console.ReadLine();
        }
    }



}