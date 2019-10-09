using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    class SettlerUnit : Unit
    {
        private int movement;
        public SettlerUnit(int movement) : base(movement) { }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("Settler Unit");
        }
        public override float Value { get => 5; }
    }
}
