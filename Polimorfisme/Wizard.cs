using System;

namespace Polimorfisme
{
    
    public class Wizard : Hero
    {
        
        public int bonusMagic;

        public override void UseSkill()
        {
            
            base.UseSkill();
            Console.WriteLine("BONUS MAGIC = " + bonusMagic);

        }
    }
}