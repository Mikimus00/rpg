using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    [Serializable()]
    class Priest : Hero
    {
        Random rnd = new Random();

        public Priest(string namep) : base (namep)
        {
            Name = namep;
            base.HP = 150;
            Skill.Add("Вылечить", healing);
        }
         public override void attack (Hero h_2)
        {
            rnd = new Random();
            int dmg = rnd.Next(1, 20);
            int dmg1 = rnd.Next(1, 20);
            h_2.HP -= dmg;
        }
         public void healing(Hero h)
         {
             rnd = new Random();
             int heal = rnd.Next(5, 10);
             h.HP += heal;
         }
    }
}
