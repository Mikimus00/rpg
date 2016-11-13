using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    public class Game
    {
        static readonly Game _instance = new Game();
        public static Game Instance
        {
            get
            {
                return _instance;
            }
        }

        public Game ()
        {
            this.addpers();
            //using (Stream stream = File.Open("saveload.bin", FileMode.Open))
            //{
            //    BinaryFormatter bin = new BinaryFormatter();
            //    Team1 = (List<Hero>)bin.Deserialize(stream);
            //}
            //using (Stream stream = File.Open("saveload2.bin", FileMode.Open))
            //{
            //    BinaryFormatter bin = new BinaryFormatter();
            //    Team2 = (List<Hero>)bin.Deserialize(stream);
            //}
        }
        public int maxnum;
        public List<Hero> Team1 = new List<Hero>();
        public List<Hero> Team2 = new List<Hero>();
        public int hod = 1;
        public int comanda;
        public bool addpers()
        {
            bool tryadd;
            maxnum = Team1.Count;
            if (maxnum < 6)
            {
                Team1.Add(new Wizard("Mediv"));
                Team1.Add(new warrior("Garrosh"));
                Team2.Add(new Priest("Anduin"));
                Team2.Add(new Wizard("Jaina"));
                Team1.Add(new Priest("Tiranda"));
                Team2.Add(new warrior("Gromash"));
                tryadd = true;
            }
            else tryadd = false;
            return tryadd; 
        }
    }
}
