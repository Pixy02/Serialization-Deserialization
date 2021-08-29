using System;
using System.IO;
using PlayerStats;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            serial serializer = new serial();
            PlayerStats.DataPlayer data = new PlayerStats.DataPlayer();
            
            string path = Directory.GetCurrentDirectory() + "/Data Player.bin";

            data.InputData();

            serializer.SerialData(data, path);

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}
