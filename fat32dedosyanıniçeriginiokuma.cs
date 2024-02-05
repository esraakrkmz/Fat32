using System;

namespace icerikokuma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fat32 = new int[100]; //fat32 tablosunda clusterları tutacak int array
            string[] hdd = new string[100]; //okuduğumuz verileri tutacağımız dizi
            int eof = -1;
            fat32[1] = 2;
            fat32[2] = 3;
            fat32[3] = 8;
            fat32[8] = 52;
            fat32[52] = eof;

            hdd[1] = "Merhaba";
            hdd[2] = "bu";
            hdd[3] = "bir";
            hdd[8] = "fat32 dizisidir";

            int startingcluster = 1;
            int pointer = startingcluster;
            string data = "";

            if (fat32[pointer] == 0)
            {
                Console.WriteLine("clustere is empty");
                return;

            }
            while (pointer != eof)
            {
                Console.WriteLine(hdd[pointer]);
                data += hdd[pointer];
                pointer = fat32[pointer];


            }
            Console.WriteLine(data);
        }
    }
}
