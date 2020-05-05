using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgramGame
{
    public class Menu
    {
        public void Stats(int healthHero, int weaponHeroMaxAttack, int count)
        {
            Console.Clear();
            Console.WriteLine("******* Состояние героя *******\n");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Health Point (HP).........{healthHero}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Сила атаки................1 - {weaponHeroMaxAttack}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Убито монстров............{count}\n");
            Console.ResetColor();
            Console.WriteLine("*******************************\n");
        }

        public void Story(string text)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void FightMenu(int healthHero,                               
                              int weaponHeroMaxAttack,
                              int healthMonster)
        {    

                        Console.Clear();
                        Console.WriteLine("******* Статистика боя ********\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"HP HГероя...............{healthHero}");
                        //Console.ForegroundColor = ConsoleColor.Green;
                        //Console.WriteLine($"Сила атаки..............{weaponHeroMinAttack}-{weaponHeroMaxAttack}");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"HP Монстра..............{healthMonster}\n");
                        Console.ResetColor();
                        Console.WriteLine("*******************************\n");
        }
        

        public void EndGame (int healthHero, int count)
        {
            Console.WriteLine("*******КОНЕЦ ИГРЫ*******\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Health Point (HP).........{healthHero}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Убито монстров............{count}\n");
            Console.ResetColor();
            Console.WriteLine("*****************************\n");

        }

    }
}
