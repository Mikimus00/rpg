using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Hero
    {
        private int _hp;
        public int HP
    {
        get
        {
            return _hp;
        }
        set
        {
            if(value < 0)
            {
                _hp = 0;
            }
            else
            {
                _hp = value;
            }
        }
    }
        public void attack(Hero h_1)
        {
            
        }
    }
}
