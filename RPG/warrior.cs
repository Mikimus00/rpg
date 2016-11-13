using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
     [Serializable()]
    class warrior : Hero
    {
        Random rnd = new Random();
         public warrior(string namewar) : base (namewar)
        {
            Name = namewar;
            base.HP = 100;
        }
        public override void attack (Hero h_1)
        {
            rnd = new Random();
            int dmg = rnd.Next(20, 30);
            h_1.HP -= dmg;
        }        
    }
}
