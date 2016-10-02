using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Wizard : Hero
    {
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
            h_3.HP -= 30;
        }
    }
}
