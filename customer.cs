using System;

namespace ePhone
{
    public class customer
    {
        private string nama;
        private string address;
        private string order;

        public void searchPhone()
        {
            Console.WriteLine("Galaxy S Series berapa yang anda cari?");
            var phone = new smartphone();
            phone.displayList();
            Console.WriteLine("\nMasukkan pilihan anda:");
            string pilihanTemp = Console.ReadLine();
            int choose = Convert.ToInt32(pilihanTemp);
            phone.pilihan(choose);
            phone.alamat();
        }
    }
}