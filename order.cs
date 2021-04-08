using System;

namespace ePhone
{
    public class order
    {
        public void format_order()
        {
            
        }
        public void name(string nama)
        {
            Console.WriteLine("Masukkan nama anda: ");
            string input_nama = Console.ReadLine();
        }
        private void nohp(int nomor)
        {
            Console.WriteLine("Masukkan nomor handphone anda: ");
            int nomor1 = Convert.ToInt32(Console.ReadLine());
        }
        public void alamat()
        {
            Console.WriteLine("\nMohon masukkan Alamat Anda\n");
            Console.WriteLine("Nama Jalan: \n");
            Console.WriteLine("RT/RW: \n");
            Console.WriteLine("Kelurahan: \n");
            Console.WriteLine("Kecamatan: \n");
            Console.WriteLine("Kode pos: \n");
            Console.WriteLine("Provinsi: \n");
            Console.WriteLine("Kota: \n");
            string alamat1 = Console.ReadLine();
            Console.WriteLine("\n\nPRODUK AKAN DIKIRIMKAN KE ALAMAT: " + alamat1);
        }
    }
}