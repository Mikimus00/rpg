using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class warrior : Hero
    {
        
        string Name;
        public int HP;  
        int ID;

         public warrior()
        {
            base.HP = 100;
        }
        public warrior(int hp)
        {
            base.HP = hp;
        }
        public void attack (Hero h_1)
        {
            h_1.HP -= 10;
        }
        
    }
       
        
}
