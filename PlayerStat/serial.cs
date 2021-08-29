using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PlayerStats
{
    public class serial
    {
        public void SerialData(DataPlayer data, string path)
        {
            // Menginisialisasi format binary
            BinaryFormatter formatter = new BinaryFormatter();

            // Membuat file sesuai tujuan
            FileStream stream = new FileStream(path, FileMode.Create);

            // Meng serialisasi data
            formatter.Serialize(stream, data);

            // Menutup File
            stream.Close();
        }
    }
}