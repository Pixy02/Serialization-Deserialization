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
            DataPlayer data = new DataPlayer();

            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                FileStream stream = new FileStream(path, FileMode.Open);

                data = formatter.Deserialize(stream) as DataPlayer;

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
