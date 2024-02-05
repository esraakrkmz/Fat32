using System;

namespace fat32
{
    class Program
    {
        static int enuzundosya(int[]fat32,int indis)
        {
            if (fat32[indis] == 0) return 0;
            int adet = 1;
            while (fat32[indis] != -1)
            {
                adet++;
                indis = fat32[indis];
                   
            }
            return adet;
        }
        static void Main(string[] args)
        {
            int [] fat32=new int [100];
            fat32[1] = 2;
            fat32[2] = 5;
            fat32[5] = -1;
            fat32[7] = -1;
            fat32[8] = 10;
            fat32[10] = 12;
            fat32[12] = 14;
            fat32[14] = -1;
            fat32[44] = -1;
            int enfazladosya=0;
            for (int i = 0; i < fat32.Length; i++)
            {
                int adet = enuzundosya(fat32, i);
                if(adet> enfazladosya)
                {
                    enfazladosya = adet;
                }
         
            }
            Console.WriteLine(enfazladosya);



        }
    }
}
