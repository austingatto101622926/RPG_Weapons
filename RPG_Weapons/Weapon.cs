using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Weapons
{
    abstract class Weapon
    {
        public string Name { get; set; }
        public int BaseDamage { get; set; }
        public int BaseRange { get; set; }
        public int CritDamage { get; set; }
        public int HitChance { get; set; }

        public Weapon(string name, int baseDamage, int baseRange, int critDamage)
        {
            Name = name;
            BaseDamage = baseDamage;
            BaseRange = baseRange;
            CritDamage = critDamage;
        }

        public int Poke(int distance)
        {
            if (distance <= BaseRange)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        virtual public int AttackRoll(int distance)
        {
            int damage = 0;
            string attackMessage = "Attack made with " + Name + " from (" + distance + "/" + BaseRange + ") meters, " ;

            if (distance <= BaseRange)
            {
                int roll = Program.RNGenerate(1,100);
                if (roll <= HitChance)
                {
                    damage = DamageRoll(distance);
                    attackMessage += "it hit(" + roll + "/" + HitChance + ") dealing " + damage + " damage";
                }
                else
                {
                    attackMessage += "it missed(" + roll + " / " + HitChance + ")";
                    damage = -1;
                }
            }
            else
            {
                attackMessage += "it was out of range and missed";
                damage = -1;
            }
            Console.WriteLine(attackMessage);
            return damage;
        }

        abstract public int DamageRoll(int distance);
    }
}
