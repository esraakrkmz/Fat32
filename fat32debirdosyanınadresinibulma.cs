using System;

namespace dosyannınadresinibulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int eof = -1;
            int[] fat32 = new int[100];
            fat32[1] = 2;
            fat32[2] = 3;
            fat32[3] = 8;
            fat32[8] = 52;
            fat32[52] = eof;

            int startingcluster = 1; //dosyanın başlangıç adresi
            int pointer = startingcluster;
            String adres = "";
            while (pointer != eof)
            {
                Console.WriteLine(pointer);
                pointer = fat32[pointer];
                adres = pointer + "->";
            }
         

        }
    }
}
