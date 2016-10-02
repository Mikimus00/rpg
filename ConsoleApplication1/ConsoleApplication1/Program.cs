using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        warrior w = new warrior();
        Priest p = new Priest();
        int w_1 = 100;
        int w_2 = 100;
        int p_1 = 150;
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            List<Hero> personage = new List<Hero>();
            personage.Add(new warrior());
            personage.Add(new Priest());
            warrior dead = new warrior();
            foreach (var hero in personage)
            {
                hero.attack(dead);
                Console.WriteLine(dead.HP);
            }
            object obj = new object();
            int pers = int.Parse(Console.ReadLine());
            Console.WriteLine("выберете героя");
            Console.WriteLine("1. Воин");
            Console.WriteLine("3. Жрец");
            switch (pers)
            {
                case 1:
                    Console.WriteLine("ты воин");
                    break;
                case 3:
                    Console.WriteLine("ты жрец");
                    break;
            }
            switch (target)
            {
                case 1:
                    
                    break;
            }
            int w_1 = 100;
            int w_2 = 100;
            while (w_1 > 0 | w_2 > 0)
            {
                if (w_1 < 0)
                    break;
                if (w_2 < 0)
                    break;
            }
        }
    }
}
