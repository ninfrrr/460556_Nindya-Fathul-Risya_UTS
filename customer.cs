using System.Reflection.Metadata.Ecma335;
using System.Data;
using System;

namespace ePhone
{
    public class customer
    {
        public void searchPhone()
        {
            Console.WriteLine("Galaxy S Series apa yang anda cari?");
            var phone = new smartphone();
            phone.displayList();
            Console.WriteLine("\nMasukkan pilihan anda:");
            string pilihanTemp = Console.ReadLine();
            int choose = Convert.ToInt32(pilihanTemp);
            phone.pilihan(choose);
            Console.WriteLine("\n\tApakah anda yakin ingin memesan ini? (ya/tidak)");
            string yakin = Console.ReadLine();
            if (yakin == "ya")
            {
                var pesen = new order();
                pesen.format_order();    
            }
            else if (yakin == "tidak")
            {
                searchPhone();
            }        
        }
    }
}