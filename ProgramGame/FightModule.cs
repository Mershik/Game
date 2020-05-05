using System;
using System.Threading;

namespace ProgramGame
{
    public class FightModule 
    {

        public int Fight(int healthHero,                      
                         int weaponHeroMaxAttack,
                         int healthMonster)
        {
            int attackM;
            int attackH;

            Random attackHero = new Random();
            Random attackMonster = new Random();
            Random critAttackHero = new Random();
            Random critAttackMonster = new Random();          

            Menu menu = new Menu();

            Menu colorfFightMenu = new Menu();
            colorfFightMenu.Story("Вы достаете оружие и готовитесь к битве\n");

            while (healthHero > 0)
            {
                menu.FightMenu(healthHero, weaponHeroMaxAttack, healthMonster);

                Thread.Sleep(1000);
                if (_ = critAttackHero.Next(1, 4) == 1)
                {
                    Console.WriteLine();
                    attackH = attackHero.Next(1, weaponHeroMaxAttack);
                    healthMonster -= attackH * 2;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Герой наносит критический урон {attackH * 2}!");
                }
                else
                {
                    Console.WriteLine();
                    attackH = attackHero.Next(1, weaponHeroMaxAttack);
                    healthMonster -= attackH;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Герой наносит урон {attackH}.");
                }
                Console.ResetColor();
                Thread.Sleep(1000);

                if (healthMonster <= 0)

                    return healthHero;

                if (critAttackMonster.Next(1, 3) == 1)
                {
                    attackM = attackMonster.Next(1, 4);
                    healthHero -= attackM * 2;

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Монстр наносит критический урон {attackH * 2}!");
                }
                else
                { 
                    attackM = attackMonster.Next(1, 4);
                    healthHero -= attackM;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Монстр наносит урон {attackM}");

                }
                Console.ResetColor();
                Thread.Sleep(1000);


                if (healthHero <= 0)
                    return healthHero;
                else if (healthMonster > 0 && healthHero > 0)
                    continue;
            }
            return healthHero;
        }
    }
}
