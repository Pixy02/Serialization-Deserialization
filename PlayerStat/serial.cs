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
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Create);

            formatter.Serialize(stream, data);

            stream.Close();
        }
    }
}
