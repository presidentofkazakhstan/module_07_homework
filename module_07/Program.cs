using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;


namespace module_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank("T-34", 0, 0, 0);
            Tank secondTank = new Tank("Panthera", 4, 5, 6);
            Tank thirdTank = new Tank("RPG", 1, 2, 3);
            Tank fourthTank = new Tank("Kuz`ma", 7, 8, 9);
            Tank fifthTank = new Tank("Alfred", 10, 11, 12);
            Console.WriteLine("Уровень защиты первого танка: " + tank.LevelTankArmor);
            Console.WriteLine("Уровень боезапаса первого танка: " + tank.LevelTankAmmunition);
            Console.WriteLine("Уровень манёврености первого танка: " + tank.LevelTankManeuverability);


            Console.WriteLine("Уровень защиты второго танка: " + secondTank.LevelTankArmor);
            Console.WriteLine("Уровень боезапаса второго танка: " + secondTank.LevelTankAmmunition);
            Console.WriteLine("Уровень манёврености второго танка: " + secondTank.LevelTankManeuverability);
            if (tank ^ secondTank)
            {
                Console.WriteLine("Первый танк выиграл");
            }
            else if (tank * secondTank)
            {
                Console.WriteLine("Ничья");
            }
            else
            {
                Console.WriteLine("Второй танк выиграл");
            }

            Console.Read();
        }
    }
}
