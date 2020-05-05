using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgramGame
{
    public class Menu
    {
        public void Stats(int healthHero, int weaponHeroMinAttack, int weaponHeroMaxAttack, int count)
        {
            Console.WriteLine("*******Состояние героя*******\n");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Health Point (HP).........{healthHero}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Сила атаки................{weaponHeroMinAttack}-{weaponHeroMaxAttack}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Убито монстров............{count}\n");
            Console.ResetColor();
            Console.WriteLine("*****************************\n");
        }

        public void Story(string text)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public void FightMenu(int healthHero, int healthMonster)
        {
            Menu colorfFightMenu = new Menu();
            
            colorfFightMenu.Story("Вы достаете оружие и готовитесь к битве\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("HP героя..................." + healthHero);
            Console.WriteLine("HP монстра................." + healthMonster);
            Thread.Sleep(3000);
            colorfFightMenu.Story("В атаку!!!\n");
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
