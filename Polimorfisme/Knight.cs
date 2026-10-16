using System;

using System.Diagnostics.Contracts;

namespace Polimorfisme
{
    
    public class Knight : Hero
    {
        
        public int bonusArmor;

        public override void UseSkill()
        {

            base.UseSkill();
            Console.WriteLine("BONUS ARMOR = " + bonusArmor);

        }
    }
}
