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
            int healthHero = 500;
            int count = 0;

            FightModule fightModule = new FightModule();
            FinalFight finalFight = new FinalFight();
            FinalFight exp = new FinalFight();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Вы спускаетесь в подземелье.");
            Console.WriteLine("Перед вами находится железная и деревянная дверь.");
            Console.WriteLine("Какую выберете 1 или 2?");
            Console.ResetColor();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();                   
                    Console.WriteLine("Вы проходите железную дверь и получаете 50 к HP!");
                    Console.WriteLine("Внезапно вы видите приближающегося огромного монстра, который вступает с вами в бой");
                    Thread.Sleep(5000);

                    healthHero = fightModule.Fight(healthHero, 150);
                    finalFight.EndFight(healthHero,40);
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
                            healthHero = fightModule.Fight(healthHero, 70);
                            finalFight.EndFight(healthHero, 40);
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
                        healthHero = fightModule.Fight(healthHero, 50);
                        finalFight.EndFight(healthHero,40);
                        Console.WriteLine();
                        Console.WriteLine($"Ты уничтожил {i} монстра");
                        Console.WriteLine();
                        Thread.Sleep(3000);
                        if (healthHero > 0)
                        {
                            healthHero += 50;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Вы истребили потомство, которое не давало жить этой долине.");
                            count++;
                        }
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
