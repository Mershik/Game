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
        static int Fight(int healthHero, int healthMonster)
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
                    healthMonster -= attackH*2;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Герой наносит критический удар {attackH*2}!");               
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
            int healthHero = 500;
            int count = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($@"Вы спускаетесь в подземелье. 
Перед вами находится железная и деревянная дверь. 
Какую выберете 1 или 2?");
            Console.ResetColor();

            String direction = Console.ReadLine();

            switch (direction)
            {
                case "1":
                    Console.WriteLine();                   
                    Console.WriteLine("Вы проходите железную дверь и получаете 50 к HP!");
                    Console.WriteLine("Внезапно вы видите приближающегося огромного монстра, который вступает с вами в бой");
                    Thread.Sleep(5000);

                    healthHero = Fight(healthHero, 150);
                    finalFight(healthHero);
                    if (healthHero > 0)
                    {
                        healthHero += 50;
                        count++;
                        Console.WriteLine("Это был длинный бой, но не следует останавливаться");
                        Thread.Sleep(3000);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Перед вами стоит три сундука, какой вы возьмете?");
                    string box = Console.ReadLine();

                    switch (box)
                    {

                        case "1":
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("В сундуке вы видите несметные богатства и ваше сердце останавливается.");
                            Thread.Sleep(5000);
                            healthHero = 0;
                            break;
                        case "2":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine();
                            Console.WriteLine("В сундуке вы находите смысл жизни и совершаете самоубийство");
                            Thread.Sleep(5000);
                            healthHero = 0;
                            break;
                        case "3":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine();
                            Console.WriteLine("В сундуке вы находите яйцо монстра, которое вылупляется и атакует");
                            Thread.Sleep(5000);
                            healthHero = Fight(healthHero, 70);
                            finalFight(healthHero);
                            if (healthHero > 0)
                            {
                                healthHero += 50;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Вы истребили потомство, которое не давало жить этой долине.");
                                count++;
                            }
                            break;
                        default:
                            Console.WriteLine("Вам падает на голову камень и вы умираете");
                            healthHero = 0;
                            break;
                    }                    
                    break;           
        
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Вы слышите топот свирепых монстров и хватаетесь за оружие ");
                    Thread.Sleep(3000);


                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine($"{i} монстр нападает");
                        healthHero = Fight(healthHero, 150);
                        finalFight(healthHero);
                        Console.WriteLine();
                        Console.WriteLine($"Ты уничтожил {i} монстра");
                        Console.WriteLine();
                        Thread.Sleep(3000);
                        count++;
                    }
                    Console.WriteLine("Комната чиста");
                    Thread.Sleep(5000);
                    break;
                default:
                    Console.WriteLine("Вы струсили и убежали");
                    break;
        }


            if (healthHero == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("YOU DIE...");
                Console.WriteLine("Ваше тело никогда не найдут, а ваше имя перемтанут вспоминать");
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Поздравляем, вы уничтожили {count} монстров. В долине вы стали героем");
            }

            Console.ReadKey();

        }
    }
}
