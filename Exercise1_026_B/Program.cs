using System;

namespace Bubble_Sort
{
    class program
    {
        //deklarasi array int ukuran 46
        private int[] davit = new int[46];

        //deklarasi variabel in untuk menyimpan data pada array yg di input user
        private int hartono;

        //method menerima masukan
        public void read()
        {
            //bentuk perulangan dan menerima data yang disimpan di array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                hartono = Int32.Parse(s);
                if (hartono <= 46)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("Masukan Elemen Array");
            Console.WriteLine("--------------------");

            for (int i = 0; i < hartono; i++)  //user memasukan elemen 
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                davit[i] = Int32.Parse(s1);
            }
        }

        public void display()
        {

            //menampilkan array yang telas disusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Elemental Array yang Telah Tersusun");
            Console.WriteLine("-----------------------------------");

            for (int DH = 0; DH < hartono; DH++)
            {
                Console.WriteLine(davit[DH]);
            }
            Console.WriteLine("");
        }

        public void tes()
        {
            for (int a = 1; a < hartono; a++) //n -1 passes
            {
                for (int DH = 0; DH < hartono - a; DH++) // pada pass i, mebandingkan n - 1 elemen pertama dgn elmn selanjutnya
                {
                    if (davit[a] < davit[DH] / a[DH] )
                    {
                        int swap;
                    }
                }
            }
        }




        public void bubble()
        {
            for (int i = 1; i < hartono; i++) // n-1 passes
            {
                for (int DH = 0; DH < hartono - i; DH++) // pada pass i, mebandingkan n - 1 elemen pertama dgn elmn selanjutnya
                {
                    if (davit[DH] > davit[DH + 1]) //jika elemen tidak urut
                    {

                        // menukar 
                        int temp;
                        temp = davit[DH];
                        davit[DH] = davit[DH + 1];
                        davit[DH + 1] = temp;

                    }
                }
            }
        }


        static void Main(string[] args)
        {
            program myList = new program(); // membuat pemanggil
            myList.read();   //memanggil kelas read
            myList.bubble();  //memangggil kelas bubble
          //  myList.tes();   //memanggil kelas tes
            myList.display();    //memanggil kelas display


            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
