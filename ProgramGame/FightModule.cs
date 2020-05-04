using System;
using System.Threading;

namespace ProgramGame
{
    public class FightModule 
    {

        public int Fight(int healthHero,
                         int healthMonster)
        {
            int attackM;
            int attackH;

            Random attackHero = new Random();
            Random attackMonster = new Random();
            Random critAttackHero = new Random();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Вы достаете оружие и готовитесь к битве");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("HP героя = " + healthHero);
            Console.WriteLine("HP монстра = " + healthMonster);
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("В Атаку!!!");
            Console.ResetColor();

            while (healthHero > 0)
            {
                if (critAttackHero.Next(1, 5) == 1)
                {
                    Console.WriteLine();
                    attackH = attackHero.Next(10, 25);
                    healthMonster -= attackH * 2;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Герой наносит критический удар {attackH * 2}!");
                    Console.ResetColor();
                    Console.WriteLine($"У монстра осталось { healthMonster} HP");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine();
                    attackH = attackHero.Next(10, 25);
                    healthMonster -= attackH;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Герой бъет с силой {attackH}.");
                    Console.ResetColor();
                    Console.WriteLine($"У монстра осталось { healthMonster} HP");
                    Thread.Sleep(500);
                }

                if (healthMonster <= 0)
                {
                    Console.WriteLine();
                    return healthHero;
                }

                attackM = attackMonster.Next(15, 25);
                healthHero -= attackM;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Монстр кусает зубами на {attackM}");
                Console.ResetColor();
                Console.WriteLine($"У героя осталось {healthHero} HP");
                Thread.Sleep(1000);
                Console.WriteLine();

                if (healthHero <= 0)
                {
                    return healthHero;
                }
                else if (healthMonster > 0 && healthHero > 0)
                {
                    continue;
                }
            }
            return healthHero;
        }
    }
}
