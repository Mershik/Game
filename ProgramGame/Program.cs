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
            int weaponHeroMinAttack = 1;
            int weaponHeroMaxAttack = 3;

            int count = 0;

            FightModule fightModule = new FightModule();
            FinalFight finalFight = new FinalFight();
            Box boxes = new Box();
            Menu menu = new Menu();
            Menu text = new Menu();


            text.Story("Вы спускаетесь в подземелье к монстрам\n");
         
            while (healthHero > 0)
            {
                menu.Stats(healthHero, weaponHeroMinAttack, weaponHeroMaxAttack, count);

                text.Story("Перед вами находится железная и деревянная дверь\nКакую выберете 1 или 2?");

                switch (Console.ReadLine())
                {
                    case "1":
                        text.Story("Вы проходите железную дверь\nВнезапно вы видите приближающегося огромного монстра, который вступает с вами в бой ");
                        Thread.Sleep(5000);

                        healthHero = fightModule.Fight(healthHero, weaponHeroMinAttack, weaponHeroMaxAttack, 10);
                        finalFight.EndFight(healthHero, 4);
                        if (healthHero > 0)
                        {
                            count++;
                            text.Story("Перед вами стоит три сундука, какой выберете?");
                            boxes.ThreeBoxes(healthHero, weaponHeroMinAttack, weaponHeroMaxAttack);
                            break;
                        }
                        else
                        {
                            break;
                        }

                    case "2":
                        text.Story("Вы слышите топот свирепых монстров и хватаетесь за оружие ");
                        Thread.Sleep(3000);

                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine($"{i} монстр нападает");
                            healthHero = fightModule.Fight(healthHero, weaponHeroMinAttack, weaponHeroMaxAttack, 5);
                            finalFight.EndFight(healthHero, 4);
                            Console.WriteLine();
                            Console.WriteLine($"Ты уничтожил {i} монстра\n");
                            Thread.Sleep(3000);
                            if (healthHero > 0)
                            {
                                healthHero += 4;
                                text.Story("Следующий монстр на подходе");
                                count++;
                            }
                            else
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Вы струсили и убежали");
                        break;
                }

                if (healthHero <= 0)
                {
                    healthHero = 5;
                    text.Story($"Внезапно вы появляетесь у входа в пещеру со {healthHero}, продолжить? 'да/нет'\n");

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
                    text.Story("Вы возвращаетесь в начало. Продолжить? 'да/нет'");

                    switch (Console.ReadLine())
                    {
                        case "да":
                            continue;

                        default:
                            text.EndGame(healthHero, count);
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
