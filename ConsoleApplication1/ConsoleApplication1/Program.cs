using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        Wizard wiz = new Wizard();
        warrior w = new warrior();
        Priest p = new Priest();
        int h_1 = 100;
        int h_2 = 100;
        int h_3 = 150;
        int h_4 = 80; 
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            List<Hero> personage = new List<Hero>();
            personage.Add(new warrior());
            personage.Add(new Priest());
            personage.Add(new Wizard());
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
            Console.WriteLine("2. Маг");
            Console.WriteLine("3. Жрец");
            switch (pers)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("что сделать?");
                    Console.WriteLine("1. ударить");
                    Console.WriteLine("2. наложить баф");
                    switch (target)
                    {
                        case 1:
                            
                            break;
                        case 2:
                            Console.WriteLine("кого бафать?");
                            Console.WriteLine("1. жреца"); 
                            Console.WriteLine("2. воина"); 
                            switch (target)
                            {
                                case 1:
                                    
                                    break;
                                case 2:

                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("что сделать?");
                    Console.WriteLine("1. ударить");
                    Console.WriteLine("2. вылечить");
                switch (target)
                    {
                    case 1:

                        break;
                    case 2:

                        break;
                    }
                    break;
            }
            Console.WriteLine("");
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
