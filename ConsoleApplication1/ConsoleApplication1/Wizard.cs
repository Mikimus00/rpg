using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Wizard : Hero
    {
        Random rnd = new Random();
        string name;
        public int HP;
        int ID;
        public Wizard()
        {
            base.HP = 80;
        }
        public Wizard(int hp)
        {
            base.HP = hp;
        }
        public void attack (Hero h_3)
        {
            rnd = new Random();
            int dmg = rnd.Next(15, 40);
            h_3.HP -= dmg;
        }
    }
}
