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
        static int Fight(int healthHero)
        {
            int healthMonster = 100;
            int attackH;
            int attackM;
            Random attackHero = new Random();
            Random attackMonster = new Random();

            while (healthHero > 0)
            {
                Console.WriteLine();
                attackH = attackHero.Next(20, 35);
                healthMonster -= attackH;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Герой бъет с силой {attackH}.");               
                Console.ResetColor();
                Console.WriteLine($"У монстра осталось { healthMonster} HP"); 
                Thread.Sleep(1000);

                if (healthMonster <= 0)
                {
                    Console.WriteLine();
                    return healthHero;
                }

                attackM = attackMonster.Next(15, 20);
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
                Console.WriteLine("Победа! Вы получили кучу опыта и 50 HP!");
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
            Console.WriteLine("На вас напали!");

            int healthHero = 100;

            healthHero = Fight(healthHero);
            finalFight(healthHero);



            Console.ReadKey();

        }
    }
}
