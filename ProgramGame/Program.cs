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
            int healthHero = 15;
            int weaponHeroMaxAttack = 3;
            //int coin = 5;

            int bonusHealth = 4;
            int count = 0;


            FightModule fightModule = new FightModule();
            FinalFight finalFight = new FinalFight();
            Box boxes = new Box();
            Menu menu = new Menu();
            Menu text = new Menu();


            text.Story("Pre-Alpha v.1.1. by Mersh\n*************************\n\nСюжетная линия слишком длинная, чтобы ее рассказывать... \nВы спускаетесь в подземелье к монстрам\n");
            Thread.Sleep(5000);

            while (healthHero > 0)
            {
                menu.Stats(healthHero, weaponHeroMaxAttack, count);

                Console.WriteLine("Далее сложная дорога, возьмете в сундуке обмундирование? \nВведите да/нет\n");

                switch (Console.ReadLine())
                {
                    case "да":
                        Console.WriteLine();
                        Console.WriteLine("Введите номер необходимого снаряжения");
                        Console.WriteLine("1. Броня");
                        Console.WriteLine("2. Оружие");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Shop shop1 = new Shop();
                                healthHero = shop1.ShopingArmor(healthHero);
                                break;

                            case "2":
                                Shop shop2 = new Shop();
                                weaponHeroMaxAttack = shop2.ShopingWeapon(weaponHeroMaxAttack);
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                 
                menu.Stats(healthHero, weaponHeroMaxAttack, count);

                text.Story("Перед вами находится железная и деревянная дверь\nКакую выберете 1 или 2?");

                switch (Console.ReadLine())
                {
                    case "1":
                        text.Story("Вы проходите железную дверь\nВнезапно вы видите приближающегося огромного монстра, который вступает с вами в бой ");
                        Thread.Sleep(5000);

                        healthHero = fightModule.Fight(healthHero, weaponHeroMaxAttack, 20);
                        healthHero = finalFight.EndFight(healthHero, weaponHeroMaxAttack, count, bonusHealth);
                        if (healthHero > 0)
                        {
                            count++;                           
                            text.Story("Перед вами стоит три сундука, какой выберете?");
                            healthHero = boxes.ThreeBoxes(healthHero, weaponHeroMaxAttack, count, bonusHealth);
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
                            healthHero = fightModule.Fight(healthHero, weaponHeroMaxAttack, 25);
                            finalFight.EndFight(healthHero, weaponHeroMaxAttack, count, bonusHealth);
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
                    healthHero = 10;
                    text.Story($"Внезапно вы появляетесь у входа в пещеру {healthHero} HP, продолжить? 'да/нет'\n");

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
