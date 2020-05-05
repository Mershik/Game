using Fight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProgramGame 
{
    public class Box 
    {
        public int ThreeBoxes(int healthHero, int weaponHeroMaxAttack, int count, int bonusHealth) 
        {
            FightModule fightModule = new FightModule();
            FinalFight finalFight = new FinalFight();

            switch (Console.ReadLine())
            {

                case "1":                  
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("В сундуке вы видите несметные богатства");
                    Console.WriteLine("*У вас случается сердечный приступ* - 3 HP");
                    Console.WriteLine("Возвращаемся назад, пока не появился новый монстр");
                    Console.WriteLine();
                    Thread.Sleep(5000);
                    healthHero -= 3;

                    break;

                case "2":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    Console.WriteLine("В сундуке яд *Вы отравились* - 2 HP");
                    Console.WriteLine("Возвращаемся назад, пока не появился новый монстр");
                    Console.WriteLine();
                    Thread.Sleep(5000);
                    healthHero -= 2;
                    break;

                case "3":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    Console.WriteLine("В сундуке вы находите яйцо монстра, которое вылупляется и атакует");
                    Thread.Sleep(5000);
                    healthHero = fightModule.Fight(healthHero, weaponHeroMaxAttack, 5);
                    finalFight.EndFight(healthHero, weaponHeroMaxAttack, count, bonusHealth); 
                    break;

                default:
                    Console.WriteLine("Вам падает на голову камень и вы умираете");
                    healthHero = 0;
                    break;

            }
            return healthHero;
        }
    }
}
