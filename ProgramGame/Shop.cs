using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgramGame
{
    public class Shop
    {
        public int ShopingArmor(int healthHero)
        {
            Console.WriteLine();
            Console.WriteLine("Введите номер необходимого снаряжения");
            Console.WriteLine("1. Легкая броня........+7 к HP");
            Console.WriteLine("2. Тяжелая броня......+10 к HP");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Вы купили Легкую броню (+7 к HP)");
                    Console.WriteLine($"Ваше здоровье - {healthHero + 7} НР");
                    return healthHero += 7;

                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Вы купили тяжелую броню (+10 к НР)");
                    Console.WriteLine($"Ваше здоровье - {healthHero + 10} НР");
                    return healthHero += 10;

                default:
                    break;
            }

            Thread.Sleep(3000);
            return healthHero;
        }


    

        public int ShopingWeapon(int weaponHeroMaxAttack)
        {
            Console.WriteLine();
            Console.WriteLine("Перечень оружия:");
            Console.WriteLine("1. Меч........+7 к Урону");
            Console.WriteLine("2. Топор......+8 к Урону");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Вы купили Меч (+7 к Урону)");
                    Console.WriteLine($"Ваш урон - {weaponHeroMaxAttack + 7}");
                    return weaponHeroMaxAttack += 7;

                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Вы купили топор (+8 к Урону)");
                    Console.WriteLine($"Ваш урон - {weaponHeroMaxAttack + 8}");
                    return weaponHeroMaxAttack += 8;

                default:
                    break;
            }
            Thread.Sleep(3000);
            return weaponHeroMaxAttack;
            }
    }
}

