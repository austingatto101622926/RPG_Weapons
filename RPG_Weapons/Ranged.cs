using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Weapons
{
    class Ranged : Weapon
    {
        public int CloseRange { get; set; }

        public Ranged(string name, int baseDamage, int baseRange, int closeRange, int critDamage) : base(name, baseDamage, baseRange, critDamage) { HitChance = 75; CloseRange = closeRange; }

        public override int AttackRoll(int distance)
        {
            int damage = 0;
            string attackMessage = "Attack made with " + Name + " from (" + CloseRange + "/" + distance + "/" + BaseRange + ") meters, ";

            if (distance >= CloseRange)
            {
                int hitChance = HitChance;
                if (distance > BaseRange) hitChance -= ((distance - BaseRange) * 2);


                int roll = Program.RNGenerate(1, 100);
                if (roll <= hitChance)
                {
                    damage = DamageRoll(distance);
                    attackMessage += "it hit(" + roll + "/" + hitChance + ") dealing " + damage + " damage";
                }
                else
                {
                    damage = -1;
                    attackMessage += "it missed(" + roll + " / " + hitChance + ")";
                }
            }
            else
            {
                attackMessage += "it was too close and missed";
                damage = -1;
            }

            Console.WriteLine(attackMessage);
            return damage;
        }

        public override int DamageRoll(int distance)
        {
            int damage = 0;
            //initial damage
            if (distance == CloseRange)
            {
                damage = BaseDamage;
            }
            else
            {
                damage = (int)(double)BaseDamage * Program.RNGenerate(50, 100) / 100;
            }
            //crit damage
            if (distance <= ((int)(double)BaseRange*0.75))
            {
                int critChance = 1;
                if (distance == CloseRange) { critChance = 2; }

                int roll = Program.RNGenerate(1, 100);
                if (roll <= critChance)
                {
                    Console.WriteLine("you crit(" + roll + "/"+critChance+")");
                    return damage * 2;
                }
            }
            return damage;
        }
    }
}
