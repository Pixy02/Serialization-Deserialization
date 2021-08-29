using System;
using System.IO;
using PlayerStats;

namespace Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // initiate object deserializer
            Deserializer deserializer = new Deserializer();

            // set file path
            string path = Directory.GetCurrentDirectory() + "/Data Player.bin";

            // run deserializer file
            PlayerStats.DataPlayer data = deserializer.DeserializeData(path);

            // show player data
            data.ShowData();

            // close program
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}