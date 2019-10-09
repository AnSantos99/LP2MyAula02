using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    internal class MilitaryUnit : Unit
    {
        private int movement;

        // Constructor receiving class base movement
        public MilitaryUnit(int movement) : base(movement) { }

        public int AttackPower { get; }

        // Property to get and set XP
        public int XP { get; set; }

        // Overriding Health property of class unit
        public override int Health { get => base.Health + XP; }

        // Overriding Value property to get attackpower and XP
        public override float Value { get => AttackPower + XP; }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("Military unit.");
        }

        public void Attack(Unit u) { }


    }
}
