using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        public string NameOfTank { get; set; }
        public int LevelTankAmmunition { get; set; }
        public int LevelTankArmor { get; set; }
        public int LevelTankManeuverability { get; set; }
        public Tank() { }
        public Tank(string nameOfTank, int levelTankArmor, int levelTankAmmunition, int levelTankManeuverability)
        {
            Random random = new Random();
            NameOfTank = nameOfTank;
            LevelTankAmmunition = random.Next(0, 100);
            LevelTankArmor = random.Next(0, 100);
            LevelTankManeuverability = random.Next(0, 100);
        }

        public static bool operator ^(Tank obj1, Tank obj2)
        {
            Tank obj = new Tank();
            if (obj1.LevelTankArmor > obj2.LevelTankArmor && obj1.LevelTankAmmunition > obj2.LevelTankAmmunition && obj1.LevelTankManeuverability > obj2.LevelTankManeuverability || obj1.LevelTankArmor < obj2.LevelTankArmor && obj1.LevelTankAmmunition > obj1.LevelTankAmmunition && obj1.LevelTankManeuverability > obj2.LevelTankAmmunition || obj1.LevelTankArmor > obj2.LevelTankArmor && obj1.LevelTankAmmunition < obj2.LevelTankAmmunition && obj1.LevelTankManeuverability > obj2.LevelTankManeuverability || obj1.LevelTankArmor > obj2.LevelTankArmor && obj1.LevelTankAmmunition > obj2.LevelTankAmmunition && obj1.LevelTankManeuverability < obj2.LevelTankManeuverability)
                return true;
            return false;
        }
        public static bool operator *(Tank obj1, Tank obj2)
        {
            Tank obj = new Tank();
            if (obj1.LevelTankArmor == obj2.LevelTankArmor && obj1.LevelTankAmmunition == obj2.LevelTankAmmunition && obj1.LevelTankManeuverability == obj2.LevelTankManeuverability)
                return true;
            return false;
        }
    }
}
