using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PlayerStats
{
    public class Deserializer
    {

        public DataPlayer DeserializeData(string path)
        {
            // membuat data player kosong
            DataPlayer data = new DataPlayer();

            if (File.Exists(path))
            {
                // menginisialisasi format binary
                BinaryFormatter formatter = new BinaryFormatter();

                // membuka file sesuai tujuan
                FileStream stream = new FileStream(path, FileMode.Open);

                // meng deserialisasi data
                data = formatter.Deserialize(stream) as DataPlayer;

                // menutup file
                stream.Close();
            }
            else
            {
                Console.WriteLine("No File Exists");
            }

            return data;
        }
    }
}