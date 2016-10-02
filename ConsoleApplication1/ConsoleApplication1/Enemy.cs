using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Enemy : Hero
    {
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
            h_4.HP -= 50;
        }
    }
}
