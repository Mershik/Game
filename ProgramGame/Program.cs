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
        static void Main(string[] args)
        {
            Console.WriteLine("На вас напали!");

            int healthHero = 100;
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

                    Console.WriteLine($"Герой бъет с силой {attackH}. \nУ монстра осталось {healthMonster} HP");
                    Thread.Sleep(1000);

                    Console.WriteLine();
                    attackM = attackMonster.Next(15, 30);
                    healthHero -= attackM;

                    Console.WriteLine($"Монстр кусает зубами на {attackM}\nУ героя осталось {healthHero} HP");
                    Thread.Sleep(1000);
                    Console.WriteLine();

                    if (healthHero <= 0)
                    {
                        Console.WriteLine("Герой храбро погиб");
                        return;
                    }
                    else if (healthMonster <= 0)
                    {
                        Console.WriteLine("Победа! Вы получили кучу опыта!");
                        return;

                    }
                    else if (healthMonster > 0 && healthHero > 0)
                    {
                        continue;
                    }
                }
          


            Console.ReadKey();

        }
    }
}
