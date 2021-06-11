using System;
using System.Collections.Generic;
using System.Text;

namespace HelpForLone
{
    /// <summary>
    /// Creates a knight class, containing the interface for the basic abilitys, the melee abilities, and the shield abilities.
    /// </summary>
    class Knight : IBasicAbilitys, IMelee, IShieldAbilitys
    {
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }

        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }

        public void RaiseShield()
        {
            Console.WriteLine("I'm raising my shield");
        }

        public void ShieldGlare()
        {
            Console.WriteLine("I'm throwing shield glare");
        }

        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }
    }
}
