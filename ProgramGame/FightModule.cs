using System;
using System.Threading;

namespace ProgramGame
{
    public class FightModule 
    {

        public int Fight(int healthHero,                      
                         int weaponHeroMinAttack,
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
            menu.FightMenu(healthHero, healthMonster);

            while (healthHero > 0)
            {
                if (critAttackHero.Next(1, 5) == 1)
                {
                    Console.WriteLine();
                    attackH = attackHero.Next(weaponHeroMinAttack, weaponHeroMaxAttack);
                    healthMonster -= attackH * 2;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Герой наносит критический удар {attackH * 2}!");
                }
                else
                {
                    Console.WriteLine();
                    attackH = attackHero.Next(weaponHeroMinAttack, weaponHeroMaxAttack);
                    healthMonster -= attackH;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Герой бъет с силой {attackH}.");
                }
                Console.ResetColor();
                Console.WriteLine($"У монстра осталось { healthMonster} HP");
                Thread.Sleep(500);

                if (healthMonster <= 0)
                    return healthHero;

                if (critAttackMonster.Next(1, 5) == 1)
                {
                    attackM = attackMonster.Next(1, 2);
                    healthHero -= attackM * 2;

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Монстр наносит критический удар когтями {attackH * 2}!");
                }
                else
                { 
                    attackM = attackMonster.Next(1, 2);
                    healthHero -= attackM;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Монстр кусает зубами на {attackM}");

                }
                Console.ResetColor();
                Console.WriteLine($"У героя осталось {healthHero} HP\n\n");
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
