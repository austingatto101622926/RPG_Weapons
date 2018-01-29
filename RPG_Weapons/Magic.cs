using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Weapons
{
    class Magic : Weapon
    {
        public Magic(string name, int baseDamage, int baseRange, int critDamage) : base(name, baseDamage, baseRange, critDamage) {HitChance = 100;}

        public override int DamageRoll(int distance)
        {
            return BaseDamage;
        }
    }
}
