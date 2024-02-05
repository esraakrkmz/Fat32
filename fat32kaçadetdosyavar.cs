using System;

namespace fat32_
{
    class Program
    {
        static void Main(string[] args)
        {
            //fat dizisinde kaç adet dosya bulunur?
            int[] fat32 = new int[100];
            fat32[1] = 2;
            fat32[2] = 5;
            fat32[5] = -1;
            fat32[7] = -1;
            fat32[8] = 10;
            fat32[10] = 12;
            fat32[12] = 14;
            fat32[14] = -1;
            fat32[44] = -1;
            int adet = 0;
            for (int i = 0; i < fat32.Length; i++)
            {
                if (fat32[i] == -1) adet++;
            }
            Console.WriteLine(adet);
        }
    }
}
