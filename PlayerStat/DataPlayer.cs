using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerStats
{
    [Serializable]
    public class DataPlayer
    {
        public string playerName;
        public int mana,level,gem,xp;

        public DataPlayer() { }

        public DataPlayer(string name, int mana, int lvl, int gem, int xp)
        {
            this.playerName = name;
            this.mana = mana;
            this.level = lvl;
            this.gem = gem;
            this.xp = xp;
        }

        public void InputData()
        {
            Console.Write("Enter Player Name: ");
            playerName = Console.ReadLine();

            Console.Write("Enter Player Mana: ");
            mana = int.Parse(Console.ReadLine());

            Console.Write("Enter Player Level: ");
            level = int.Parse(Console.ReadLine());

            Console.Write("Enter Player Gem: ");
            gem = int.Parse(Console.ReadLine());

            Console.Write("Enter Player XP: ");
            xp = int.Parse(Console.ReadLine());
        }

        public void ShowData()
        {
            Console.WriteLine(playerName);
            Console.WriteLine(mana);
            Console.WriteLine(level);
            Console.WriteLine(gem);
            Console.WriteLine(xp);
        }

        static void Main() { }
    }
}