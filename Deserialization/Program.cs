using System;
using System.IO;
using PlayerStats;

namespace Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {    
            Deserializer deserializer = new Deserializer();

            string path = Directory.GetCurrentDirectory() + "/Data Player.bin";

            PlayerStats.DataPlayer data = deserializer.DeserializeData(path);

            data.ShowData();

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}
