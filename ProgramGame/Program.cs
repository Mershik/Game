using System;
using System.Text;
using System.Threading;
using ProgramGame;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            int healthHero = 10;
            int count = 0;

            FightModule fightModule = new FightModule();
            FinalFight finalFight = new FinalFight();
            Box boxes = new Box();

         
            Console.WriteLine("Вы спускаетесь в подземелье к монстрам");
            while (healthHero > 0)
            {
                Console.WriteLine();
                Console.WriteLine("*******Состояние героя*******");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine($"Health Point (HP).........{healthHero}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Убито монстров............{count}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("*****************************");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Перед вами находится железная и деревянная дверь.");
                Console.WriteLine("Какую выберете 1 или 2?");
                Console.ResetColor();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Вы проходите железную дверь");
                        Console.WriteLine("Внезапно вы видите приближающегося огромного монстра, который вступает с вами в бой");
                        Thread.Sleep(5000);

                        healthHero = fightModule.Fight(healthHero, 7);
                        finalFight.EndFight(healthHero, 4);
                        if (healthHero > 0)
                        {
                            count++;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Перед вами стоит три сундука, какой вы возьмете?");
                            boxes.ThreeBoxes(healthHero);
                            break;
                        }
                        else
                        {
                            break;
                        }

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("Вы слышите топот свирепых монстров и хватаетесь за оружие ");
                        Thread.Sleep(3000);

                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine($"{i} монстр нападает");
                            healthHero = fightModule.Fight(healthHero, 5);
                            finalFight.EndFight(healthHero, 4);
                            Console.WriteLine();
                            Console.WriteLine($"Ты уничтожил {i} монстра");
                            Console.WriteLine();
                            Thread.Sleep(3000);
                            if (healthHero > 0)
                            {
                                healthHero += 5;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Вы истребили потомство, которое не давало жить этой долине.");
                                Console.ResetColor();
                                count++;
                                Console.WriteLine("Комната чиста");
                                Thread.Sleep(5000);
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Вы струсили и убежали");
                        break;
                }

                if (healthHero <= 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    healthHero = 5;
                    Console.WriteLine($"Внезапно вы появляетесь у входа в пещеру со {healthHero}, продолжить? 'да/нет'");
                    Console.WriteLine();

                    switch (Console.ReadLine())
                    {
                        case "да":
                            continue;

                        default:
                            healthHero = -1;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Вы возвращаетесь в начало. Продолжить? 'да/нет'");
                    Console.WriteLine();

                    switch (Console.ReadLine())
                    {
                        case "да":
                            continue;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("*******КОНЕЦ ИГРЫ*******");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine($"Health Point (HP).........{healthHero}");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"Убито монстров............{count}");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine("*****************************");
                            Console.WriteLine();

                            healthHero = -1;
                            break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Спасибо за игру!");
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
