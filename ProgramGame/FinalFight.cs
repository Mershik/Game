using System;
using System.Threading;

namespace ProgramGame
{
    public class FinalFight
    {
        public int EndFight(int healthHero, int weaponHeroMinAttack, int weaponHeroMaxAttack, int count, int bonusHealth)
        {
            if (healthHero > 0)
            {
                Menu menu = new Menu();
                Console.WriteLine("*****************************");
                menu.Story($"ПОБЕДА!\nМонстр мертв и его душа излечивает вас на {bonusHealth} HP!\n");
                healthHero += bonusHealth;
                Console.WriteLine("*****************************\n");
                menu.Story("Это был трудный бой, но не следует останавливаться");
                Thread.Sleep(3000);
                menu.Stats(healthHero, weaponHeroMinAttack, weaponHeroMaxAttack, count);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*****************************\n");
                Console.WriteLine("     Герой храбро погиб\n");
                Console.WriteLine("*****************************\n");
                Thread.Sleep(3000);               
                Console.ResetColor();
            }

            return healthHero;
        }
    }

}

