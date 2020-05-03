using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Fight
{
    class Program
    {
        static int Fight(int healthHero, int attackH)
        {
            int healthMonster = 100;
            int attackM;

            Random attackHero = new Random();
            Random attackMonster = new Random();
            Random critAttackHero = new Random();

            while (healthHero > 0)
            {
                if (critAttackHero.Next(1, 5) == 1)
                {
                    Console.WriteLine();
                    attackH = attackHero.Next(20, attackH);
                    healthMonster -= attackH*2;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Герой наности критический удар {attackH*2}!");               
                    Console.ResetColor();
                    Console.WriteLine($"У монстра осталось { healthMonster} HP"); 
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine();
                    attackH = attackHero.Next(20, attackH);
                    healthMonster -= attackH;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Герой бъет с силой {attackH}.");
                    Console.ResetColor();
                    Console.WriteLine($"У монстра осталось { healthMonster} HP");
                    Thread.Sleep(1000);
                }
              
                if (healthMonster <= 0)
                {
                    Console.WriteLine();
                    return healthHero;
                }

                attackM = attackMonster.Next(10, 20);
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

        static int finalFight(int healthHero)
        {
            if (healthHero > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Монстр мертв и его душа излечивает вас на 50 HP!");
                Console.ResetColor();
                Console.WriteLine("Ваше ХП " + (healthHero + 50));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Герой храбро погиб");
                Console.ResetColor();
            }

            return healthHero;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(@"Вы спускаетесь в подземелье и видите, 
 как на вас прыгает свирепый монстр");

            int healthHero = 100;
            int attackH = 30;
            int count = 0;

            while (healthHero > 0)
            {
                healthHero = Fight(healthHero, attackH);
                finalFight(healthHero);
                count++;
                healthHero += 50;
                if (count == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Победа! Вы уничтожили {count - 1} монстров! Подземелье в безопасности");                   
                    Console.ResetColor();
                    return;
                }
            }
            Console.WriteLine($"Вы уничтожили {count - 1} монстров");
            
            Console.ReadKey();

        }
    }
}
