using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Weapons
{
    class Melee : Weapon
    {
        public Melee(string name, int baseDamage, int baseRange, int critDamage) : base(name, baseDamage, baseRange, critDamage) { HitChance = 85; }

        public override int DamageRoll(int distance)
        {
            int damage = 0;
            //initial damage
            if (distance <= BaseRange/2)
            {
                damage = (int)((double)BaseDamage * 1.2);
            }
            else
            {
                damage = BaseDamage;
            }
            //crit damage
            int roll = Program.RNGenerate(1, 100);
            if (roll <= 2)
            {
                Console.WriteLine("you crit("+roll+"/2)");
                return damage * 2;
            }
            else
            {
                return damage;
            }
        }
    }
}
