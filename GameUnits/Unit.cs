using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    internal abstract class Unit
    {
        // Class variable movement
        private int movement;

        // Health property
        public virtual int Health { get; set; }

        // Readonly Value property
        public abstract float Value { get; }

        public Unit(int movement) 
        {
            this.movement = movement;
        }

        /// <summary>
        /// Virtual function to get units move
        /// </summary>
        public virtual void Move() 
        {
            Console.WriteLine("Movements of ");
        }
    }
}
