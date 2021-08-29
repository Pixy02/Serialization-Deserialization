using System;
using System.IO;
using PlayerStats;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // menginisialisasi data dan serializer  
            serial serializer = new serial();
            PlayerStats.DataPlayer data = new PlayerStats.DataPlayer();

            // tujuan penyimpanan
            string path = Directory.GetCurrentDirectory() + "/Data Player.bin";

            // menginput data player
            data.InputData();

            // menjalankan serialisasi
            serializer.SerialData(data, path);

            // menutup data
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}