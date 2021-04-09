using System.Reflection.Metadata.Ecma335;
using System.Data;
using System;

namespace ePhone
{
    public class customer
    {
        // private string nama;
        // private string address;
        // private string order;
        public void searchPhone()
        {
            Console.WriteLine("Galaxy S Series berapa yang anda cari?");
            var phone = new smartphone();
            phone.displayList();
            Console.WriteLine("\nMasukkan pilihan anda:");
            string pilihanTemp = Console.ReadLine();
            int choose = Convert.ToInt32(pilihanTemp);
            phone.pilihan(choose);
            Console.WriteLine("\n\tApakah anda yakin akan memesan ini? (ya/tidak)");
            string yakin = Console.ReadLine();
            if (yakin == "ya")
            {
                var pesen = new order();
                pesen.format_order();    
            }
            else if (yakin == "tidak")
            {
                Console.WriteLine("\n\tSilakan pilih kembali tipe yang anda inginkan!");
                phone.pilihan(choose);
            }
            // var tampil = new order();
            // Console.WriteLine("PAKET ATAS NAMA: " + input_name);            
        }
    }
}