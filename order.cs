using System;

namespace ePhone
{
    public class order
    {
        string nama;
        string nomorhp;
        string alamat1;
        string alamat2;
        string alamat3;
        string alamat4;
        string alamat5;
        string alamat6;
        string alamat7;


        public void format_order()
        {
            name();
            nohp();
            alamat();
            add_data();
        }
        public void name()
        {
            Console.WriteLine("\nMasukkan nama lengkap anda: ");
            nama = Console.ReadLine();
        }
        private void nohp()
        {
            Console.WriteLine("\nMasukkan nomor handphone anda: ");
            nomorhp = Console.ReadLine();
        }
        public void alamat()
        {
            Console.WriteLine("\n\tMohon masukkan alamat lengkap Anda");
            Console.WriteLine("\nNama Jalan: ");
            alamat1 = Console.ReadLine();
            Console.WriteLine("\nRT/RW: ");
            alamat2 = Console.ReadLine();
            Console.WriteLine("\nKelurahan: ");
            alamat3 = Console.ReadLine();
            Console.WriteLine("\nKecamatan: ");
            alamat4 = Console.ReadLine();
            Console.WriteLine("\nKabupaten/Kota: ");
            alamat5 = Console.ReadLine();
            Console.WriteLine("\nProvinsi: ");
            alamat6 = Console.ReadLine();
            Console.WriteLine("\nKode pos: ");
            alamat7 = Console.ReadLine();
            
        }

        public void add_data(){
            var tambah = new data(nama, nomorhp, alamat1, alamat2, alamat3, alamat4, alamat5, alamat6, alamat7);
            Console.WriteLine("PRODUK AKAN DIKIRIMKAN ATAS NAMA: " + tambah.get_nama());
            Console.WriteLine("DENGAN NOMOR HP: " + tambah.get_nohp());
            Console.WriteLine("PRODUK AKAN DIKIRIMKAN KE ALAMAT: \n" + tambah.get_alamat1() + ", " + tambah.get_alamat2() + ", " + tambah.get_alamat3() +", " + tambah.get_alamat4() +", " + tambah.get_alamat5() +", " + tambah.get_alamat6() + ", " + tambah.get_alamat7() + ".\n");
        }
    }
}