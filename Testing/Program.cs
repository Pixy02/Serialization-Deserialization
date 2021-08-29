using PlayerStats;
using System;
using System.IO;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        PlayerStats.DataPlayer dataTest = new DataPlayer("Name Test", 50, 35, 4500 , 300);
        string path = Directory.GetCurrentDirectory() + "/PlayerTesting.bin";

        [Fact]
        public void SerializeWorkTest()
        {
            serial serializer = new serial();

            serializer.SerialData(dataTest, path);
        }

        [Fact]
        public void DeserializeWorkTest()
        {
            PlayerStats.DataPlayer data = new PlayerStats.DataPlayer();
            Deserializer deserializer = new Deserializer();

            data = deserializer.DeserializeData(path);
        }

        [Fact]
        public void IsThereCreatedFileTest()
        {
            bool cond = true;

            if (!File.Exists(path))
            {
                cond = false;
            }

            Assert.True(cond);
        }

        [Fact]
        public void TestEqualData()
        {
            serial serializer = new serial();
            serializer.SerialData(dataTest, path);

            PlayerStats.DataPlayer data = new PlayerStats.DataPlayer();
            Deserializer deserializer = new Deserializer();
            data = deserializer.DeserializeData(path);

            bool cond = true;
            if (data.playerName != dataTest.playerName) cond = false;
            if (data.mana != dataTest.mana) cond = false;
            if (data.level != dataTest.level) cond = false;
            if (data.gem != dataTest.gem) cond = false;
            if (data.xp != dataTest.xp) cond = false;

            Assert.True(cond);
        }
    }
}