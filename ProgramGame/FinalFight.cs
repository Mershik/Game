using System;
using System.Threading;

namespace ProgramGame
{
    public class FinalFight
    {
        public int EndFight(int healthHero, int bonusHealth)
        {
            if (healthHero > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Монстр мертв и его душа излечивает вас на {bonusHealth} HP!");
                Console.ResetColor();
                Console.WriteLine("Ваше ХП " + (healthHero + bonusHealth));
                healthHero += bonusHealth;
                Console.WriteLine("Это был длинный бой, но не следует останавливаться");
                Thread.Sleep(3000);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("*****************************");
                Console.WriteLine();
                Console.WriteLine("     Герой храбро погиб");
                Console.WriteLine(); 
                Console.WriteLine("*****************************");

                Thread.Sleep(3000);
               
                Console.ResetColor();
            }
            return healthHero;
        }
    }

}
