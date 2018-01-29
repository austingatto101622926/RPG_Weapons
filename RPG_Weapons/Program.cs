using System;

namespace RPG_Weapons
{
    class Program
    {
        public static Random RNG = new Random();
        public static int RNGenerate(int min, int max)
        {
            return RNG.Next(min, max + 1);
        }

        static void Main(string[] args)
        {
            int damage = 0;
                                        //Name, BaseDamage, BaseRange, CritDamage(unused)
            Magic fireStaff = new Magic("Staff of Fire", 22, 60, 0);
            Melee excalibur = new Melee("Excalibur", 50, 2, 250);
                                        //Name, BaseDamage, BaseRange, CloseRange, CritDamage(unused)
            Ranged longbow = new Ranged("The Bow of Cupid", 100, 60, 30, 300);

            Console.WriteLine("MAGIC WEAPONS");
            damage = fireStaff.AttackRoll(0); Console.WriteLine(" // output: "+damage);
            damage = fireStaff.AttackRoll(1); Console.WriteLine(" // output: " + damage);
            damage = fireStaff.AttackRoll(60); Console.WriteLine(" // output: " + damage);
            damage = fireStaff.AttackRoll(75); Console.WriteLine(" // output: " + damage);
            Console.WriteLine();

            Console.WriteLine("MELEE WEAPONS");
            damage = excalibur.AttackRoll(0); Console.WriteLine(" // output: " + damage);
            damage = excalibur.AttackRoll(1); Console.WriteLine(" // output: " + damage);
            damage = excalibur.AttackRoll(2); Console.WriteLine(" // output: " + damage);
            damage = excalibur.AttackRoll(3); Console.WriteLine(" // output: " + damage);
            Console.WriteLine();

            Console.WriteLine("RANGED WEAPONS");
            damage = longbow.AttackRoll(20); Console.WriteLine(" // output: " + damage);
            damage = longbow.AttackRoll(30); Console.WriteLine(" // output: " + damage);
            damage = longbow.AttackRoll(45); Console.WriteLine(" // output: " + damage);
            damage = longbow.AttackRoll(60); Console.WriteLine(" // output: " + damage);
            damage = longbow.AttackRoll(75); Console.WriteLine(" // output: " + damage);
            damage = longbow.AttackRoll(90); Console.WriteLine(" // output: " + damage);

            Console.ReadLine();
        }
    }
}
