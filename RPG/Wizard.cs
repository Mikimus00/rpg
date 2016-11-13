using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    [Serializable()]
    class Wizard : Hero
    { 
        Random rnd = new Random();
        public Wizard(string namewiz) : base (namewiz)
        {
            base.HP = 80;
            Name = namewiz;
        }
        public override void attack (Hero h)
        {
            rnd = new Random();
            int dmg = rnd.Next(15, 40);
            h.HP -= dmg;
        }
    }
}
