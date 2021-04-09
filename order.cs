using System;

namespace ePhone
{
    public class order
    {
        public void format_order()
        {
            name();
            nohp();
            alamat();
        }
        public void name()
        {
            Console.WriteLine("\nMasukkan nama lengkap anda: ");
            string input_nama = Console.ReadLine();
        }
        private void nohp()
        {
            Console.WriteLine("\nMasukkan nomor handphone anda: ");
            long nomor1 = Convert.ToInt64(Console.ReadLine());
        }
        public void alamat()
        {
            Console.WriteLine("\n\tMohon masukkan alamat lengkap Anda");
            Console.WriteLine("\nNama Jalan: ");
            string alamat1 = Console.ReadLine();
            Console.WriteLine("\nRT/RW: ");
            string alamat2 = Console.ReadLine();
            Console.WriteLine("\nKelurahan: ");
            string alamat3 = Console.ReadLine();
            Console.WriteLine("\nKecamatan: ");
            string alamat4 = Console.ReadLine();
            Console.WriteLine("\nKabupaten/Kota: ");
            string alamat5 = Console.ReadLine();
            Console.WriteLine("\nProvinsi: ");
            string alamat6 = Console.ReadLine();
            Console.WriteLine("\nKode pos: ");
            string alamat7 = Console.ReadLine();
            
            name();
            string input_nama = Console.ReadLine();
            Console.WriteLine("\n\nPRODUK AKAN DIKIRIMKAN ATAS NAMA: " + input_nama);
            nohp();
            long nomor1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n\nDENGAN NOMOR HP: " + nomor1);
            Console.WriteLine("\n\nPRODUK AKAN DIKIRIMKAN KE ALAMAT: \n" + alamat1 + ", " + alamat2 + ", " + alamat3 +", " + alamat4 +", " + alamat5 +", " + alamat6 + ", " + alamat7 + ".\n");
        }
    }
}