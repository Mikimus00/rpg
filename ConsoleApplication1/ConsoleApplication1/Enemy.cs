using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Enemy : Hero
    {
        Random rnd = new Random();
        public int HP;
        int ID;
        public Enemy()
        {
            base.HP = 300;
        }
        public Enemy(int hp)
        {
            base.HP = hp;
        }
        public void attack (Hero h_4)
        {
            rnd = new Random();
            int dmg = rnd.Next(1, 20);
            h_4.HP -= dmg;
        }
    }
}
