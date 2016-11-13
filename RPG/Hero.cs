using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    [Serializable()]
    public class Hero
    {
 
        public delegate void skills (Hero hero);
        public Dictionary<string,skills> Skill;
        public Hero(string name)
        {
            Skill = new Dictionary<string,skills>();
            Skill.Add("Атаковать", attack);
        }
        public string Name;
        private int _hp;
        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                if(value <= 0)
                {
                    _hp = 0;
                    if (OnDeath != null)
                    {
                        OnDeath(this);
                    }
                }
                else
                {
                    _hp = value;
                }
            }
        }
        public event skills OnDeath;
        public virtual void attack(Hero h_2)
        {
            
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
