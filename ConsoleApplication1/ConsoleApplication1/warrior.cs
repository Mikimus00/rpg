using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class warrior : Hero
    {
        Random rnd = new Random();        
        public string Namew = Console.ReadLine();
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
            rnd = new Random();
            int dmg = rnd.Next(20, 30);
            h_1.HP -= dmg;
        }        
    }
}
