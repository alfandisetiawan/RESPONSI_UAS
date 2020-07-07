using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer

        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            bool ulang = true;
            while (ulang)

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("++menu utama++");
            Console.WriteLine("1=>tambah costumer");
            Console.WriteLine("2=>hapus costumer");
            Console.WriteLine("3=>tampilkan costumer");
            Console.WriteLine("4=>keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection
            Customer Customer = new Customer();

            Console.WriteLine("++tamah data costumer++");
            Console.WriteLine("kode constumer :");
            Customer.kode = Console.ReadLine();
            Console.WriteLine("nama constumer :");
            Customer.nama = Console.ReadLine();
            Console.WriteLine("total piutang");
            Customer.total = Console.ReadLine();
            daftarCustomer.Add(Customer);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus customer dari dalam collection
            int no = -1,hapus = -1;
            Console.WriteLine("++hapus data costumer++");
            Console.WriteLine("kode costumer :");
            string kd = Console.ReadLine();
            foreach (Customer Customer in daftarCustomer){
                no++;
            if(Customer.kode == kd){
                    hapus = no;
                }
            }
            if (hapus != -1){
                daftarCustomer.RemoveAt(hapus);
                Console.WriteLine("kode costumer berhasil dihapus");
            }
            else{
                Console.WriteLine("kode costumer tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
        

        static void TampilCustomer()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar customer yang ada di dalam collection
            int nomor = 0;
            Console.WriteLine("++data costumer++");
            foreach (Customer Customer in daftarCustomer){
                nomor++;
                Console.WriteLine("{0}.{1},{2}",nomor,Customer.nama,Customer.total);

            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
