﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Priest : Hero
    {
       
        string name;
        public int HP;
        int ID;
        
        public Priest()
        {
            base.HP = 150;
        }
        public Priest(int hp)
        {
            base.HP = hp;
        }
        public void attack (Hero h_2)
        {
            h_2.HP -= 5;
        }
    }
}
